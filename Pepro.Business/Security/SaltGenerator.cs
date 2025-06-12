using System.Security.Cryptography;

namespace Pepro.Business.Security;

static class SaltGenerator {
    public static byte[] GenerateSalt(int saltSize) {
        using RandomNumberGenerator generator = RandomNumberGenerator.Create();
        var salt = new byte[saltSize];
        generator.GetBytes(salt);
        return salt;
    }
}
