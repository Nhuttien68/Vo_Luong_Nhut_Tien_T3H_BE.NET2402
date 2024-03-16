using System;

namespace Bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap vao mot chuoi ki tu");
            string input = Console.ReadLine();
            string revesed = "";
             for (int i = input.Length -1 ; i >= 0  ; i--) {
                 revesed += input[i];
            }
             Console.WriteLine("chuoi dao nguoc la:"+revesed);
            Console.ReadKey();  
        }
    }
}
