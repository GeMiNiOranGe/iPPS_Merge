using System.Security.Authentication;
using Pepro.Business.Utilities;
using Pepro.Business.Security;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class AccountBusiness
{
    private static AccountBusiness? instance;

    public static AccountBusiness Instance
    {
        get => instance ??= new();
        private set => instance = value;
    }

    private AccountBusiness() { }

    public LoginResult TryLogin(string accountName, string password)
    {
        LoginResult loginResult = new();

        if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(password))
        {
            loginResult.Status = LoginStatus.InvalidInput;
            return loginResult;
        }

        Account? account = AccountDataAccess.Instance.FindAccount(accountName);

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
}
