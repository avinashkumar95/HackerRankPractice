using System;
using System.Collections.Generic;

namespace HackerRankPractice
{
    public class AppleAndOrange
    {
        public AppleAndOrange()
        {
        }
        /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int[] applesAr = apples.ToArray();
            int[] orangesAr = oranges.ToArray();
            int[] appleAr = new int[applesAr.Length];
            int[] orrangeAr = new int[orangesAr.Length];
            int countApple = 0;
            int countOrange = 0;
            for (int i = 0; i < appleAr.Length; i++)
            {
                appleAr[i] = applesAr[i] + a;
                if (appleAr[i] >= s && appleAr[i] <= t) countApple++;
            }
            for (int i = 0; i < orangesAr.Length; i++)
            {
                orrangeAr[i] = orangesAr[i] + b;
                if (orrangeAr[i] >= s && orrangeAr[i] <= t) countOrange++;
            }
            Console.WriteLine("{0}\n{1}", countApple, countOrange);
        }

    }
}
