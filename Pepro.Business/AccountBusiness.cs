using System.Security.Authentication;
using Pepro.Business.Utilities;
using Pepro.Business.Security;
using Pepro.DataAccess;
using Pepro.DTOs;
using Microsoft.IdentityModel.Tokens;

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

    public LoginStatus GetLoginStatus(string accountName, string password)
    {
        if (accountName.IsNullOrEmpty() || password.IsNullOrEmpty())
        {
            return LoginStatus.InvalidInput;
        }

        Account? account = AccountDataAccess.Instance.GetAccountDetails(accountName);

        if (account == null)
        {
            return LoginStatus.InvalidAccount;
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
            return LoginStatus.InvalidAccount;
        }

        return account.IsActive ? LoginStatus.Success : LoginStatus.LockedAccount;
    }
}
