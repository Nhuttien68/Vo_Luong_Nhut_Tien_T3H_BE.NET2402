using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Moi Nhap chuoi: ");
            string input = Console.ReadLine();
            Console.Write("Nhap ki tu ban muon tim: ");
            char find = Console.ReadKey().KeyChar; 
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < input.Length; i++ )
            {
                if (input[i] == find)
                {
                    count ++;
                }
            }
            Console.WriteLine("ki tu "+find+ " xuat hien "+count+ " lan trong chuoi");
            Console.ReadKey();
        }
    }
}
