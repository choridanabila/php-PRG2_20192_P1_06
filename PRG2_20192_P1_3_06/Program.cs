using System;

namespace PRG2_20192_P1_3_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Inputan anak ayam sejumlah N, Nilai N harus berniali positif dan tidak boleh 0.
            Console.Write("N = ");
            int N = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("ANAK AYAM TURUN 10\n");
            int i = N;
            while (i >= 2)
            {
                Console.Write("Anak ayam turun {0}", i);
                i--;
                Console.WriteLine(", mati satu tinggal {0}", i);
            }
            Console.WriteLine("Anak ayam turun {0} mati satu tinggal induknya", i);
        }
    }
}
