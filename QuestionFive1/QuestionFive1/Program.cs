using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Binary Number:: ");
            int number = int.Parse(Console.ReadLine());
            int remainder = 0,i=1,deci=0;
            while (number != 0)
            {


                remainder = number % 2;
                deci = deci + remainder * i;
                number = number / 10;
                i = i * 2;


            }
            Console.WriteLine("Decimal:: " + deci);
            Console.ReadKey();
        }
    }
}
