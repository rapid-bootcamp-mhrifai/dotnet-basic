using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal08
    {
        public Logic02Soal08()
        {
        }

        public static void CetakData(int n)
        {
            Console.WriteLine("Soal08" + "\n");
            int[] deret = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= 1) deret[j] = 1;
                    else deret[j] = deret[j - 1] + deret[j - 2];

                    if (j >= n / 2 && j <= n - i - 1
                            || j <= n / 2 && j >= n - i - 1)
                    {
                        if (n / 2 < i) Console.Write(deret[n - i - 1] + "\t");
                        else Console.Write(deret[i] + "\t");
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

