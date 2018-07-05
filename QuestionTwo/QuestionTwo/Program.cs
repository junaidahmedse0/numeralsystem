using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            double decimalNum = 0;
            int i = 1;
            int deci = 0, rem = 0;
            Console.WriteLine("Enter Binary Number:: ");
            int binary = int.Parse(Console.ReadLine());
            int[] hex = new int[100];
            /* while (binary > 0)
             {

                 deci = binary % 10;
                 decimalNum = decimalNum + deci * Math.Pow(2, pow);

                 binary = binary / 10;
                 ++pow;
             }
             Console.WriteLine("Binary Number:: " + decimalNum);

             */



            while (binary > 0)
            {

                rem = binary % 2;
                deci = deci + rem * i;
                i = i * 2;

                binary = binary / 10;



            }

            Console.WriteLine("Decimal number:: " + deci);
            i = 0;
            while (deci != 0)
            {
                hex[i] = deci % 16;
                deci = deci / 16;
                i++;


            }
            for (int j = i - 1; j >= 0; j--)
            {
                if (hex[j] > 9)
                {

                    Console.Write("" + (char)(hex[j] + 55));


                }
                else
                {

                    Console.Write("" + hex[j]);

                }


            }

            Console.ReadKey();
        }
    }
}
