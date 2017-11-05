using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CubicsMessages
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "Over!")
            {
                int num = int.Parse(Console.ReadLine());
                GetEncryptedMsg(input, num);
                input = Console.ReadLine();
            }
        }

        private static void GetEncryptedMsg(string input, int num)
        {
            string pattern = $@"^(\d+)([A-Za-z]{{{num}}})(\d*)[^A-Za-z]*$";
            Match m = Regex.Match(input, pattern);
            if (!m.Success)
            {
                return;
            }
            string message = m.Groups[2].Value;
            string verifCode = m.Groups[1].Value + m.Groups[3].Value;
            string verifMsg = "";

            foreach (char ch in verifCode)
            {
                int index = int.Parse(ch.ToString());
                verifMsg += index < message.Length ? message[index].ToString() : " ";
            }

            Console.WriteLine($"{message} == {verifMsg}");

        }
    }
}
