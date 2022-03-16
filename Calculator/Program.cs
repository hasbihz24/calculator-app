using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine(" ");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Input Nomor Menu [1-4] : ");
            int pilih = int.Parse(Console.ReadLine());
            if (pilih == 1 || pilih == 2 || pilih == 3 || pilih == 4)
            { 
                Console.Write("Inputkan nilai 1 = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                if (pilih == 1)
                {
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                }
                else if (pilih == 2)
                {
                    Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
                }
                else if (pilih == 3)
                {
                    Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
                }
                else if (pilih == 4)
                {
                    Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
                }
            }
            else
            {
                Console.WriteLine("Maaf Menu yang anda pilih tidak tersedia ");
            }
            Console.WriteLine("\nTekan Sembarang Key Untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
