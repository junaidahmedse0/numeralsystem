using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueustionSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimal Number:: ");
            int num = int.Parse(Console.ReadLine());
            string s = "0123456789ABCDEF";
            int remainder = 0;
            int i = 0;
            string str2="";
            char[] hexaDeci = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            while (num > 0)
            {

                remainder = num % 16;
                str2 = hexaDeci[remainder] + str2;
                num = num / 16;
                /*if (remainder > 9)
                {
                    hexaDeci[i] =(char) (remainder + 55);
                    i++;

                    //Console.Write("" +(char)( remainder + 55));

                }
                else
                {
                    //Console.Write("" +remainder);
                    hexaDeci[i] =(char)remainder;
                    i++;
                }*/
             
            }
            Console.WriteLine("decimal To hexaDecimal::  " + str2);
            
            Console.ReadKey();
        }
    }
}
