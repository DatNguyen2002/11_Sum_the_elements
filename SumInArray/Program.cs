using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInArray
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());

            int[] Arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap Gia tri phan tu thu {i}: ");
                Arr[i] =  int.Parse(Console.ReadLine());
            }

            int tong = 0;
            foreach (int num in Arr)
            {
                tong += num ;
            }

            Console.ReadKey();
        }

        
    }
}
