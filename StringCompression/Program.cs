using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Compress("aaabb"));
            Console.WriteLine(Compress("aadffexcd"));
            Console.WriteLine(Compress("zzmmpppp"));
            Console.WriteLine(Compress("ssssssssddddddasdsadas"));
            Console.WriteLine(Compress("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            Console.WriteLine(Compress("abcdefghijklmnopqrstuvwxyz"));
        }
        public static string Compress(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    stringBuilder.Append(input[i-1]);
                    stringBuilder.Append(count);
                    count = 1;
                }
            }
            stringBuilder.Append(input[input.Length - 1]);
            stringBuilder.Append(count);
            return stringBuilder.ToString().Length>=input.Length ?  input :  stringBuilder.ToString();
        }
    }
}
