using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt
{
    public class Cryption
    {
        public static string Encrypt(string plainString)
        {
            byte[] encryptedBytes = Encoding.ASCII.GetBytes(plainString);
            string encrypted = "";

            foreach (byte digit in encryptedBytes)
            {
                encrypted += digit;
            }

            return encrypted;
        }
        public static string Decrypt(string encryptedString)
        {
            string decrypted = "";
            IEnumerable<string> arr = Enumerable.Range(0, encryptedString.Length / 3).Select(i => encryptedString.Substring(i * 3, 3));
            List<byte> byteArr = new List<byte>();
            string[] strArr = arr.ToArray();

            List<int> list = new List<int>();
            foreach (string k in strArr)
            {
                list.Add(Int32.Parse(k));
            }
            int[] myInts = list.ToArray();

            foreach (int num in myInts)
            {
                byteArr.Add((byte)num);
            }

            decrypted = Encoding.UTF8.GetString(byteArr.ToArray<byte>());
            return decrypted;
        }
    }
}
