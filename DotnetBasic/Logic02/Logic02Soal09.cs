using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal09
    {
        public Logic02Soal09()
        {
        }

        public static void CetakData(int n)
        {
            Console.WriteLine("Soal09" + "\n");
            int[,] deret = new int[n, n];
            int kolom = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == n / 2 || j == 0 && i == n / 2) deret[i,j] = 1;
                    else if (j == n / 2 && i <= n / 2) deret[i, j] = deret[i - 1, j] + 2;
                    else if (j == n / 2 && i > n / 2) deret[i, j] = deret[i - 1, j] - 2;
                }
                if (i <= n / 2 && i > 0)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        deret[i, n / 2 - k] = deret[i, n / 2] - 2 * k;
                        deret[i, n / 2 + k] = deret[i, n / 2] - 2 * k;
                    }
                    kolom++;
                }
                else
                {
                    for (int k = 1; k <= kolom; k++)
                    {
                        deret[i, n / 2 - k] = deret[i, n / 2] - 2 * k;
                        deret[i, n / 2 + k] = deret[i, n / 2] - 2 * k;
                    }
                    kolom--;
                }
            }

            int nilaiTengah = n / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j - i <= nilaiTengah
                            && i - j <= nilaiTengah
                            && i + j >= nilaiTengah
                            && i + j <= nilaiTengah + n - 1)
                    {
                        Console.Write(deret[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("\n");
        }
    }
}

