using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayPatika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bitkiler = new string[9];
            string[] hayvanlar = { "Kedi", "Köpek", "Aslan", "Balık", "Kuş", "Civciv" };
            int[] dizi;
            dizi = new int[4];
            bitkiler[0] = "Papatya";
            dizi[3] = 11;

            Console.WriteLine(hayvanlar[3]);
            Console.WriteLine(bitkiler[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine("*********************");

            Console.WriteLine("Eleman sayısı giriniz");
            int n = int.Parse(Console.ReadLine());
            int[] sayilar = new int[n];
            int toplam = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());

            }
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine(toplam / n);
        }
    }
}
