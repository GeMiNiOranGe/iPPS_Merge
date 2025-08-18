using Pepro.Business.Security;

namespace Pepro.Business.Utilities;

public static class EncryptionConverter
{
    public static byte[]? EncryptFromString(string? plainText)
    {
        if (string.IsNullOrEmpty(plainText))
        {
            return null;
        }
        return AesEncryptor.Encrypt(plainText);
    }

    public static string? DecryptToString(byte[]? cipherText)
    {
        bool hasPermmission = true;
        if (!hasPermmission)
        {
            return cipherText != null ? "**********" : null;
        }
        if (cipherText == null || cipherText.Length <= 0)
        {
            return null;
        }
        return AesEncryptor.Decrypt(cipherText);
    }
}