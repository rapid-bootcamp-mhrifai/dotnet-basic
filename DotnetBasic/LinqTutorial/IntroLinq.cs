using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class IntroLinq
    {
        public IntroLinq()
        {
        }

        public static void Introduction()
        {
            // Specify the data source.
            int[] scores = { 97, 92, 81, 60, 63, 83, 66, 88, 85 };
            // tanpa linq
            // for untuk filter tanpa linq (language-integrated query)
            List<int> listScore = new List<int>();
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > 80)
                {
                    listScore.Add(scores[i]);
                }
            }
            // for untuk menampilkan

            /*
            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;
            */
            // Execute the query.
            foreach (int i in listScore)
            {
                Console.Write(i + " ");
            }
        }
    }
}
