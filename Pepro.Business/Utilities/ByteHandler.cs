namespace Pepro.Business.Utilities;

static class ByteHandler
{
    public static byte[] Combine(params byte[][] arrays)
    {
        byte[] result = new byte[arrays.Sum(array => array.Length)];
        int currentOffset = 0;

        foreach (byte[] array in arrays)
        {
            Buffer.BlockCopy(array, 0, result, currentOffset, array.Length);
            currentOffset += array.Length;
        }

        return result;
    }
}
