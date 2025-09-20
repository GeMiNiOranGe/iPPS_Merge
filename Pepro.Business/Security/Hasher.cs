using System.Security.Authentication;
using System.Security.Cryptography;
using Pepro.Business.Utilities;

namespace Pepro.Business.Security;

internal class Hasher(HashAlgorithmType type, int saltSize)
{
    private readonly HashAlgorithmType _type = type;
    private readonly int _saltSize = saltSize;

    public byte[] ComputeHash(byte[] buffer)
    {
        using HashAlgorithm algorithm = CreateHashAlgorithm(_type);
        byte[] hashedMessage = algorithm.ComputeHash(buffer);
        return hashedMessage;
    }

    public HashResult ComputeHashWithSalt(byte[] buffer)
    {
        byte[] salt = SaltGenerator.GenerateSalt(_saltSize);
        byte[] saltedBuffer = ByteHandler.Combine(buffer, salt);
        byte[] hashedBuffer = ComputeHash(saltedBuffer);
        return new(hashedBuffer, salt);
    }

    public bool Verify(byte[] message, byte[] expected)
    {
        byte[] hashedMessage = ComputeHash(message);
        return hashedMessage.SequenceEqual(expected);
    }

    public bool Verify(byte[] message, byte[] expected, byte[] salt)
    {
        byte[] saltedMessage = ByteHandler.Combine(message, salt);
        return Verify(saltedMessage, expected);
    }

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
}
