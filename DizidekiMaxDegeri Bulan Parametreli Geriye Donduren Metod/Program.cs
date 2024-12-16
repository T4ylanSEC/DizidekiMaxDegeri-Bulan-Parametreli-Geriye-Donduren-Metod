using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizidekiMaxDegeri_Bulan_Parametreli_Geriye_Donduren_Metod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = { 12, 96, 7, 8, 128, 35, 25, 6666, 35, 10, 958, 416, 1298, 25, 256};

            int enBuyuk = EnBuyukDegeriBul(sayilar);
            Console.WriteLine("Dizideki En Büyük Değer: " + enBuyuk);

            Console.ReadKey();
        }

        static int EnBuyukDegeriBul(int[] dizi)
        {
            if (dizi == null || dizi.Length == 0)
                throw new ArgumentException("Dizi boş veya sıfır olamaz.");

            int enBuyuk = dizi[0];

            foreach (int sayi in dizi)
            {
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }

            return enBuyuk;

        }
    }
}
