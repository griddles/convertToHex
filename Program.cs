using System;
using System.Text;

namespace convertToHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string HexConverter(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            string hexString = BitConverter.ToString(bytes);
            return hexString.Replace("-", " ");
        }
    }
}
