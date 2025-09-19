using System.Security.Authentication;
using Pepro.Business.Utilities;
using Pepro.Business.Security;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class AccountBusiness
{
    private static AccountBusiness? _instance;

    public static AccountBusiness Instance
    {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private AccountBusiness() { }

    public IEnumerable<AccountView> GetAccountViews()
    {
        IEnumerable<Account> accounts = AccountDataAccess.Instance.GetMany();
        return MapAccountsToViews(accounts);
    }

    public IEnumerable<object> SearchAccountViews(string searchValue)
    {
        IEnumerable<Account> accounts = AccountDataAccess.Instance.Search(searchValue);
        return MapAccountsToViews(accounts);
    }

    public int InsertDefaultAccountByEmployee(Employee employee)
    {
        string username = AccountHelper.GenerateDefaultUsername(employee);

        byte[] defaultPassword = DefaultConverter.GetBytes(username);
        byte[] salt = SaltGenerator.GenerateSalt(32);
        byte[] saltedPassword = ByteHandler.Combine(defaultPassword, salt);
        byte[] hashedPassword = Hasher.ComputeHash(saltedPassword, HashAlgorithmType.Sha256);

        Account account = new()
        {
            AccountId = default,
            Username = username,
            Password = hashedPassword,
            Salt = salt,
            IsActive = true,
            EmployeeId = employee.EmployeeId
        };
        return AccountDataAccess.Instance.Insert(account);
    }

    public LoginResult TryLogin(string accountName, string password)
    {
        LoginResult loginResult = new();

        if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(password))
        {
            loginResult.Status = LoginStatus.InvalidInput;
            return loginResult;
        }

        Account? account = AccountDataAccess.Instance.Find(accountName);

        if (account == null)
        {
            loginResult.Status = LoginStatus.InvalidAccount;
            return loginResult;
        }

        byte[] castPassword = DefaultConverter.GetBytes(password);
        byte[] saltedPassword = ByteHandler.Combine(castPassword, account.Salt);
        bool isSamePassword = Hasher.VerifyMessage(
            saltedPassword,
            account.Password,
            HashAlgorithmType.Sha256
        );

        if (!isSamePassword)
        {
            loginResult.Status = LoginStatus.InvalidAccount;
            return loginResult;
        }

        loginResult.EmployeeId = account.EmployeeId;
        loginResult.Status = account.IsActive ? LoginStatus.Success : LoginStatus.LockedAccount;
        return loginResult;
    }

    public int DeleteAccount(int accountId)
    {
        return AccountDataAccess.Instance.Delete(accountId);
    }

    private IEnumerable<AccountView> MapAccountsToViews(IEnumerable<Account> accounts)
    {
        IEnumerable<int> employeeIds = accounts
            .Select(account => account.EmployeeId)
            .Distinct();

        Dictionary<int, string> employees = EmployeeBusiness
            .Instance.GetEmployeesByEmployeeIds(employeeIds)
            .ToDictionary(
                employee => employee.EmployeeId,
                employee => employee.FullName
            );

        return accounts.Select(account =>
        {
            employees.TryGetValue(account.EmployeeId, out string? fullName);

            return new AccountView
            {
                AccountId = account.AccountId,
                Username = account.Username,
                IsActive = account.IsActive,
                EmployeeId = account.EmployeeId,
                EmployeeFullName = fullName ?? string.Empty,
            };
        });
    }
}
