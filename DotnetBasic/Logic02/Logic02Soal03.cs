using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal03
    {
        public Logic02Soal03()
        {
        }

        public static void CetakData(int n)
        {
            Console.WriteLine("Logic02Soal03" + "\n");
            for (int i = 0; i < n; i++)
            {
                int angka = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == 0 || i == n - 1 || j == n - 1 ||
                        i == j || i + j == n - 1)
                    {
                        Console.Write(angka + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                    angka += 2;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
