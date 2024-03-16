using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("moi nhap vao 1 so nguyen duong");
            int input;
            if (int.TryParse(Console.ReadLine(), out input) && input >= 0)
            {
                int giaiThua = 1;
                int i = 1;

                do
                {
                    giaiThua *= i;
                    i++;
                } while (i <= input);
                Console.WriteLine("Gia thua cua "+input+" là " + giaiThua);
            }
            else
            {
                Console.WriteLine("Vui Long nhap so nguyen duong!!!");
            }
            
            Console.ReadKey();  
        }
    }
}
