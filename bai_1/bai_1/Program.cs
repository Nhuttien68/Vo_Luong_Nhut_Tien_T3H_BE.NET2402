using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("moi nhap vao 1 so nguyen duong");
            int number;
            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                if (number > 2) {
                    Console.WriteLine("cac so nguyen to nho hon "+number+" là ");
                    for (int i = 2; i <= number; i++)
                    {
                        Boolean isPrime = true;
                        for (int j = 2; j <= Math.Sqrt(i); j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                        {
                            Console.WriteLine(i);
                        }
                    }

                } else { Console.WriteLine(" khong co so nguyen to nao be hon  " + number); }
            }
            else
            {
                Console.WriteLine("chi duoc nhap so nguyen duong");
            }
            Console.ReadKey();
        }
    }
}

