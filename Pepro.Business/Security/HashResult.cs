namespace Pepro.Business.Security;

public readonly record struct HashResult(byte[] HashedMessage, byte[] Salt);
