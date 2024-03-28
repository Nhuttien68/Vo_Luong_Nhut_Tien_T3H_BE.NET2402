using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_buoi_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = null;
            Boolean check = false;
            while (!check) {
                Console.WriteLine("\n ------------MENU--------------");
                Console.WriteLine("1/ Nhap vao mang so nguyen");
                Console.WriteLine("2/ In ra so chan va le tu mang");
                Console.WriteLine("3/ Mang tang dan va giam dan ");
                Console.WriteLine("4/ Tong cac so le va cac so chan");
                Console.WriteLine("5/ kiem tra som armstrong");
                Console.WriteLine("6/ Tong cac so nguyen to");
                Console.WriteLine("7/ Thoat khoi menu");
                Console.Write(" Moi ban chon chuc nang (1-7) : ");
                String choice = Console.ReadLine();
                Console.WriteLine("-------------------------------");
                switch (choice)
                {
                    case "1":
                        arr = inputArray();
                        Console.Write("Mang vua nhap la :");
                        printArray(arr);
                        break;
                    case "2":
                        if (arr != null)
                        {
                            printOddEvenNum(arr);
                        }
                        else
                            Console.WriteLine("ban can nhap mang trc.");
                        break;
                    case "3": 
                        if(arr != null)
                        {
                            sortArray(arr); 
                        }
                        else
                        {
                            Console.WriteLine("ban can nhap mang trc.");
                        }
                        break;
                    case "4":
                        if(arr != null)
                        {
                            sumOfArr(arr);
                        }
                        else
                        {
                            Console.WriteLine("ban can nhap mang trc.");
                        }
                        break;
                    case "5":
                        if ( arr != null)
                        {
                            amsrstrongNumber(arr);
                        }
                        else
                        {
                            Console.WriteLine("ban can nhap mang trc.");
                        } break;
                    case "6":
                        if ( arr != null)
                        {
                            sumPrime(arr);
                        }
                        else
                        {
                            Console.WriteLine("ban can nhap vao mang trc");
                        }break;
                    default:
                        Console.WriteLine("lua chon khong hop le.");
                        break;
                }          
            }
        }
        // hàm số 1 
        static int[] inputArray() {
            Console.Write("Moi nhap chieu dai cua mang : ");
            int lenght ;
            Boolean check = false;
            while (true) {
                if (int.TryParse(Console.ReadLine(), out lenght) && lenght != null && lenght > 0)
                {
                    int[] array = new int[lenght];
                    for (int i = 0; i < lenght; i++) {
                        Boolean checkElement = false;
                        while( !checkElement)
                        {
                            Console.Write("Moi nhap phan tu thu "+(i + 1) +":" );
                            string inputElement = Console.ReadLine();
                            if (int.TryParse(inputElement,out int element)){
                                array[i] = element;
                                checkElement = true;
                            }
                            else
                            {
                                Console.WriteLine("Phan tu chi dc nhap so nguyen!!");
                            }
                        }
                    }
                    check = true;
                    return array;
                } else
                {
                    Console.WriteLine("chieu dai mang chi dc nhap so nguyen duong va khong dc bo trong");
                    Console.Write("moi nhap lai so nguyen :");
                }
            }   
        }
        static void printArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
        }
        // hàm 2 
        static void printOddEvenNum(int[] arr)
        {
            Console.Write("Mang so le la:");
            foreach(var num in arr)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.Write("\nMang so chan la:");
            foreach (var num in arr)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
        }
        // hàm 3 
        static void sortArray(int[] arr)
        {
            int length = arr.Length;
            Console.Write("mang sap xep giam dan:");
            for (int i = 0;i < length - 1; i++)
            {
               for (int j = 0;j < length - i -1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            } 
            printArray(arr);
            Console.Write("\nMang sap xep tang  dan ");
            for(int i = 0; i < length -1 ; i++)
            {
                for(int j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            printArray(arr);
        }
        // hàm 4
        static void sumOfArr(int[] arr)
        {
            int sumOdd = 0;
            int sumEven = 0;
            foreach (int number in arr) { 
            if ( number % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
             }
            Console.Write(" tong cac so le trong mang la : "+sumOdd);
            Console.Write("\ntong cac so chan trong mang la : "+sumEven);

        }
        // hàm 5
        static void amsrstrongNumber(int[] arr)
        {
            foreach (int number in arr)
            {
               int sum = 0;
                int temp = number;
                int length = 0;
                int songuyenban = number;
                while (temp != 0)
                {
                    length++;
                    temp /= 10;
                }
                temp = songuyenban;
                while (temp != 0)
                {
                    int digit = temp % 10;
                    int result = 1;
                    for (int i = 0; i < length; i++)
                    {
                        result *= digit;
                    }
                    sum += result;
                    temp /= 10;
                }
                if (sum == songuyenban)
                {
                    Console.WriteLine(songuyenban+" là số Armstrong.");
                }
                else
                {
                   Console.WriteLine(songuyenban+ "không phải là số Armstrong.");
                }
            }
        }
        static bool isPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true; 
        }
        static void sumPrime(int[] arr) {
            int sum = 0;
            foreach (int num in arr)
            {
                if (isPrime(num))
                {
                    sum += num;
                }               
            }
            Console.WriteLine(" tong cac so nguyen to trong mang là"+sum); 
        }

    }
}
