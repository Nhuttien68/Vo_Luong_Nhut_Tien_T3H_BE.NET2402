using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            bool check = false;

            do
            {
                Console.Write("Moi ban nhap mat khau (tu 6-12 ky tu, co ky tu @): ");
                password = Console.ReadLine();

                if (password.Length >= 6 && password.Length <= 12 && password.Contains("@"))
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Mat khau khong hop le. Vui long nhap lai!");
                }
            } while (!check);

            Console.WriteLine("Mat khau hop le!");
            Console.ReadKey();
        }
    }
}
