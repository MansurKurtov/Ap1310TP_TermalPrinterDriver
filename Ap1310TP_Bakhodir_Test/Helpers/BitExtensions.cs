using System.IO;

namespace Ap1310TP_Bakhodir_Test.Helpers
{
    internal static class BitExtensions
    {
        internal static byte BitsToByte(this int[] bits)
        {
            if (bits.Length < 8)
                return default;

            int check0 = bits[0];
            int check1 = bits[1];
            int check2 = bits[2];
            int check3 = bits[3];
            int check4 = bits[4];
            int check5 = bits[5];
            int check6 = bits[6];
            int check7 = bits[7];

            return (byte)(check0 | check1 << 1 | check2 << 2 | check3 << 3 | check4 << 4 | check5 << 5 | check6 << 6 | check7 << 7);
        }

        internal static byte[] ImageToByteArray(this System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
