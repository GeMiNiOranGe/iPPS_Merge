using System.Security.Authentication;
using System.Security.Cryptography;

namespace Pepro.Business.Security;

static class Hasher
{
    // Factory method Design Pattern
    private static HashAlgorithm CreateHashAlgorithm(HashAlgorithmType type)
    {
        return type switch
        {
            HashAlgorithmType.Md5 => MD5.Create(),
            HashAlgorithmType.Sha1 => SHA1.Create(),
            HashAlgorithmType.Sha256 => SHA256.Create(),
            HashAlgorithmType.Sha384 => SHA384.Create(),
            HashAlgorithmType.Sha512 => SHA512.Create(),
            _ => throw new ArgumentException("Invalid hash algorithm type."),
        };
    }

    public static byte[] ComputeHash(byte[] message, HashAlgorithmType type)
    {
        using HashAlgorithm algorithm = CreateHashAlgorithm(type);
        byte[] hashedMessage = algorithm.ComputeHash(message);
        return hashedMessage;
    }

    public static bool VerifyMessage(
        byte[] rawMessage,
        byte[] hashedMessage,
        HashAlgorithmType hashAlgorithmType
    )
    {
        byte[] hashedRawMessage = ComputeHash(rawMessage, hashAlgorithmType);
        return hashedRawMessage.SequenceEqual(hashedMessage);
    }
}
