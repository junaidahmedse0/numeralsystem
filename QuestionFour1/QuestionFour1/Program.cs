using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:: ");
            int num = int.Parse(Console.ReadLine());
            int[] binary = new int[100];
            int i = 0;
            while (num > 0)
            {

                binary[i] = num % 2;
                num = num / 2;
                i++;


            }
            for (int j = i-1; j >=0 ; j--)
            {

                Console.Write("" + binary[j]);

            }

            Console.ReadKey();
        }
    }
}
