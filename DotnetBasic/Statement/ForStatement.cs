using System;
namespace Statement
{
    public class ForStatement
    {
        public ForStatement()
        {
        }

        public static void SampleFor()
        {
            Console.WriteLine("Masukan Angka : ");
            string? nStr = Console.ReadLine();
            // jika str itu bernilai null, maka n diberi nilai 0
            // else maka nStr di conver ke Integer
            int n = nStr == null ? 0 : int.Parse(nStr);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write("[" + i + "," + j + "]\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}

