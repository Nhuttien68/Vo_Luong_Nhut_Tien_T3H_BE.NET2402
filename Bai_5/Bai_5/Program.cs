using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100); 
            int guess = 0; 
            do
            {
                Console.Write("Moi nhap vao so tu 1 - 100: ");
                int input = Console.ReadLine();

              
                if (!int.TryParse( input, out guess))
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ.");
                    continue;
                }

                // So sánh số đoán với số ngẫu nhiên
                if (guess < randomNumber)
                {
                    Console.WriteLine("số ban nhap vao thap hon so cua chung toi."+input+ "<" +randomNumber);
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Quá cao. Hãy thử lại.");
                }
            } while (guess != randomNumber);

            Console.WriteLine("Chúc mừng! Bạn đã đoán đúng số.");
            Console.ReadKey();

        }
    }
}
