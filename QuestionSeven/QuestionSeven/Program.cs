using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value in hexaDecimal format:: ");
            string s = Console.ReadLine();
            string digits = "0123456789ABCDEF";
            s = s.ToUpper();
            int value = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int d = digits.IndexOf(c);
                value = 16 * value + d;

            }
            Console.WriteLine("Decimal number:: " + value);
            Console.ReadKey();

        }
    }
}
