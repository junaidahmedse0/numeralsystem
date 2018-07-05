using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Binary Number");

            int binary = int.Parse(Console.ReadLine());
            int deci = 0;
            int remainder;
            int i = 1;
            while(binary>0)
            {
                remainder = binary % 2;
                deci = deci + remainder * i;
                binary = binary / 10;
                i = i * 2;
            }
            Console.WriteLine("decimal:: " + deci);
            Console.ReadKey();





            Console.ReadKey();
        }
    }
}
