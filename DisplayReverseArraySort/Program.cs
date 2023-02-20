using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayReverseArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[15];
            string temp;
            int num;

            for (int i = 0; i < 15; i++)
            {
                do
                {
                    Console.Write("Enter an integer number: ");
                    temp = Console.ReadLine();

                } while (int.TryParse(temp, out num) == false);

                number[i] = num;
            }

            Console.WriteLine("Inputs in reverse order");
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(number[i]);
            }

            Console.WriteLine("\nArray Sort");
            for (int x = 0; x < number.Length - 1; x++)
            {
                for (int y = 0; y < number.Length - 1; y++)
                {
                    if (number[y] > number[y + 1])
                    {
                        num = number[y + 1];
                        number[y + 1] = number[y];
                        number[y] = num;
                    }
                }
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }



            Console.ReadKey();
        }
    }
}
