using System;

namespace PRG2_20192_P1_4_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("1. Hitung Luas");
            Console.WriteLine("2. Hitung Hipotenusa");
            Console.WriteLine("3. Hitung Keliling");
            Console.WriteLine("4. Keluar");

            Console.Write("Menu Pilihan : ");
            int x = Convert.ToInt16(Console.ReadLine());
            switch (x)
            {
                case 1:   
                    hitungluas();
                    break;
                case 2:   
                    hitunghipotenusa();
                    break;
                case 3:   
                    hitungkeliling();
                    break;
                case 4:   
                    Environment.Exit(0);
                    break;
            }
        }

        static void hitungluas()
        {
            Console.WriteLine("\n\nLUAS SEGITIGA");
            Console.Write("Masukkan alas : ");
            int alas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            int tinggi = Convert.ToInt16(Console.ReadLine());
            int luas = alas * tinggi;
            Console.WriteLine("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, luas);
        }

        static void hitunghipotenusa()
        {
            Console.WriteLine("\n\nHIPOTENUSA SEGITIGA");
            Console.Write("Masukkan alas : ");
            int alas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            int tinggi = Convert.ToInt16(Console.ReadLine());
            int hipotenusa = Convert.ToInt16(Math.Sqrt((alas*alas) + (tinggi*tinggi)));
            Console.WriteLine("Hipotenusa dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, hipotenusa);
        }

        static void hitungkeliling()
        {
            Console.WriteLine("\n\nKELILING SEGITIGA");
            Console.Write("Masukkan alas : ");
            int alas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            int tinggi = Convert.ToInt16(Console.ReadLine());
            // untuk mendapatkan hipotenusa
            int hipotenusa = Convert.ToInt16(Math.Sqrt((alas * alas) + (tinggi * tinggi)));
            int kel = alas + tinggi + hipotenusa;
            Console.WriteLine("Keliling segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, kel);
        }
    }
}
