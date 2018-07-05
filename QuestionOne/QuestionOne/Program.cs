using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:: ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            int[] arr = new int[100];

            while (num > 0)
            {
                arr[i++] = num % 2;
                num=num / 2;
         


            }

            for (int j = i-1; j >0; j--)
            {
                Console.Write("" + arr[j]);
            }
            Console.ReadKey();
        }
    }
}
