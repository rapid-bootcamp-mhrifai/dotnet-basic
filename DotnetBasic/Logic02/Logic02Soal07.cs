using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal07
    {
        public Logic02Soal07()
        {
        }

        public static void CetakData(int n)
        {
            Console.WriteLine("Soal07" + "\n");
            int[,] deret = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= 1 || i <= 1 || i >= n - 2 || j >= n - 2) deret[i, j] = 1;
                    else if (j >= i && j < n - i) deret[i, j] = deret[i - 1,n / 2] + deret[i - 2, n / 2];
                    else if (j >= n - i - 1 && j <= i) deret[i, j] = deret[n - i - 2, n / 2] + deret[n - i - 3, n / 2];
                    else if (j <= n / 2) deret[i, j] = deret[i, j - 1] + deret[i, j - 2];
                    else if (j >= n / 2) deret[i, j] = deret[n / 2, n - j - 2] + deret[n / 2, n - j - 3];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= i && j >= n - i - 1 && n / 2 <= i
                            || j <= i && j <= n - i - 1 && n / 2 >= i
                            || j >= n / 2 && j <= n - i - 1
                            || j <= n / 2 && j >= n - i - 1)
                    {
                        Console.Write(deret[i,j] + "\t");
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

