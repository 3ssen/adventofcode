using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise1");
            Exercise1();
            Console.WriteLine("Exercise2");
            Exercise2();
        }

        public static string secret = "bgvyzdsv";
        
        /// <summary>
        /// http://blogs.msdn.com/b/csharpfaq/archive/2006/10/09/how-do-i-calculate-a-md5-hash-from-a-string_3f00_.aspx
        /// </summary>
        static void Exercise1()
        {
            bool found = false;
            int i = 0;
            while(!found)
            {
                i++;
                string result = CalculateMD5Hash(secret + i.ToString());
                if (result.Substring(0, 5) == "00000")
                    found = true;                
                
            }
            Console.WriteLine(secret + i.ToString());
            Console.ReadLine();
        }
        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        static void Exercise2()
        {
            bool found = false;
            int i = 0;
            while (!found)
            {
                i++;
                string result = CalculateMD5Hash(secret + i.ToString());
                if (result.Substring(0, 6) == "000000")
                    found = true;

            }
            Console.WriteLine(secret + i.ToString());
            Console.ReadLine();
        }
    }
}
