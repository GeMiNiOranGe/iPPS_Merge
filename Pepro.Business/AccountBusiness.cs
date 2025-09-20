using System.Security.Authentication;
using Pepro.Business.Utilities;
using Pepro.Business.Security;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;
using Pepro.DataAccess.Contracts;

namespace Pepro.Business;

public class AccountBusiness
{
    private readonly Hasher _hasher = new(HashAlgorithmType.Sha256, 32);
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
        HashResult hashResult = _hasher.ComputeHashWithSalt(defaultPassword);

        Account account = new()
        {
            AccountId = default,
            Username = username,
            Password = hashResult.HashedMessage,
            Salt = hashResult.Salt,
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
        if (!_hasher.Verify(castPassword, account.Password, account.Salt))
        {
            loginResult.Status = LoginStatus.InvalidAccount;
            return loginResult;
        }

        loginResult.EmployeeId = account.EmployeeId;
        loginResult.Status = account.IsActive ? LoginStatus.Success : LoginStatus.LockedAccount;
        return loginResult;
    }

    public int ToggleActiveAccount(int accountId)
    {
        return AccountDataAccess.Instance.ToggleActive(accountId);
    }

    public int ResetPasswordAccount(int accountId)
    {
        Account? account = AccountDataAccess.Instance.GetById(accountId);
        if (account == null)
        {
            return 0;
        }

        byte[] defaultPassword = DefaultConverter.GetBytes(account.Username);
        if (_hasher.Verify(defaultPassword, account.Password, account.Salt))
        {
            return 0;
        }

        HashResult hashResult = _hasher.ComputeHashWithSalt(defaultPassword);
        AccountUpdate updateInfo = new()
        {
            Password = new(hashResult.HashedMessage, true),
            Salt = new(hashResult.Salt, true),
        };

        return AccountDataAccess.Instance.Update(accountId, updateInfo);
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
