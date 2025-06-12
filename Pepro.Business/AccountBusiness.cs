using System.Security.Authentication;
using Pepro.Business.Utilities;
using Pepro.Business.Security;
using Pepro.DataAccess;
using Pepro.DTOs;

namespace Pepro.Business;

public class AccountBusiness
{
    public const string USER_ID_PLACEHOLDER = "ID người dùng";
    public const string PASSWORD_PLACEHOLDER = "Mật khẩu";

    private static AccountBusiness? instance;

    public static AccountBusiness Instance
    {
        get => instance ??= new();
        private set => instance = value;
    }

    public AccountBusiness() { }

    public LoginStatus GetLoginStatus(string accountName, string password)
    {
        try
        {
            if (accountName == USER_ID_PLACEHOLDER && password == PASSWORD_PLACEHOLDER)
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
        catch (Exception)
        {
            // Logs can be written here if needed.
            return LoginStatus.OtherError;
        }
    }
}
