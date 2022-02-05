using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankPractice
{
    public class GemStone
    {
        public GemStone()
        {
            List<string> arr = new List<string>();
            arr.Add("abcdde");
            arr.Add("baccd");
            arr.Add("eeabg");
            Console.WriteLine(gemstones(arr));
        }
        /*
     * Complete the 'gemstones' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING_ARRAY arr as parameter.
     */

        public static int gemstones(List<string> arr)
        {
            string[] arrCpy = arr.ToArray();
            char[] c = arrCpy[0].ToCharArray();
            for(int i = 1; i < arrCpy.Length; i++)
            {
                c = c.Intersect(arrCpy[i].ToCharArray()).ToArray();
            }
            return c.Length;
        }
    }
}
