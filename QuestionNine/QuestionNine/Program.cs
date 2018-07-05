using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionNine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Binary Number:: ");
            int binary = int.Parse(Console.ReadLine());
            int remainder = 0;
            int deci = 0;
            int i = 1;
            while (binary > 0)
            {
                remainder = binary % 2;
                deci = deci + remainder * i;
                binary = binary / 10;
                i = i * 2;
                


            }
            Console.WriteLine("Decimal number is:: "+deci);
            while (deci > 0)
            {
                remainder = deci % 16;



                deci = deci / 16;
                if (remainder > 9)
                {

                    Console.Write("" +(char) (remainder + 55));

                }
                else
                {

                    Console.Write("" + remainder);

                }
            }
            Console.ReadKey();

        }
    }
}
