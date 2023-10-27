using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPair_27._10._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz :");
            int number = int.Parse(Console.ReadLine());
            Armstrong(number);
        }

        static void Armstrong(int number)
        {
            string strNumber = number.ToString();

            double total = 0;

            for (int i = 0; i < strNumber.Length; i++)
            {
                int nmbr = int.Parse(strNumber[i].ToString());

                double calculate = Math.Pow(nmbr, strNumber.Length);

                total += calculate;
            }

            if (total == number)
            {
                Console.WriteLine("Bu sayı bir Armstrong sayısıdır.");
            }
            else
            {
                Console.WriteLine("Bu sayı bir Armstrong sayısı değildir.");
            }
            
        }
    }
}
