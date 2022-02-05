using System;
namespace HackerRankPractice
{
    public class FunnyString
    {
        public FunnyString()
        {
            Console.WriteLine(funnyString("ovyvzvptyvpvpxyztlrztsrztztqvrxtxuxq"));     //Fun
            Console.WriteLine(funnyString("holtm"));                                    //Not Fun
            Console.WriteLine(funnyString("uvzxrumuztyqyvpnji"));                       //Fun
            Console.WriteLine(funnyString("tmruzxzuwoskqysxztuvosuyrswrnmtxvzsrqw" +
                "ytzrxpltrwusxupw"));                                                   //Fun
            Console.WriteLine(funnyString("wxstwxuzuyuvyzrsxysxyuvyqxuxyskqwsyqu" +
                "mqrvopvowqumnvrxpwqpwsrnvrztxrxpvuxunvyzvupvupowvyzvzuzwvsrwv"));      //Fun
            Console.WriteLine(funnyString("yrzxrxskrtlpwpmtpxvowrxrpxq"));              //Not Fun
            Console.WriteLine(funnyString("pryumtuntmovpwvowslj"));                     //Fun
            Console.WriteLine(funnyString("nosklrxrtyuxtmnurzsryuxtywqwqpxts"));        //Not Fun
            Console.WriteLine(funnyString("fmpszyvqwxrtvpuwqszvyvotmsxsxuvzyvpw" +
                "zrpmuxqwtswvytytzsnuxuyrpvtysqoutzurqxury"));                          //Not Fun
            Console.WriteLine(funnyString("jkmsxzwrxzy"));                              //Not Fun
        }

        /*
         * Complete the 'funnyString' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        private static string funnyString(string s)
        {
            int[] sArr = new int[s.Length - 1];
            int[] sRArr = new int[s.Length - 1];
            char[] sC = s.ToCharArray();
            bool status = true;
            for (int i = 0; i < s.Length - 2; i++)
            {
                // Console.WriteLine("sC[i + 1]:{0}  sC[i]:{1}  Diff:{2}", (int)sC[i + 1], (int)sC[i], (int)sC[i + 1] - (int)sC[i]);
                sArr[i] = Modulus((int)sC[i + 1] - (int)sC[i]);
                sRArr[i] = Modulus((int)sC[sC.Length - i - 1] - (int)sC[sC.Length - i - 2]);
                // Console.WriteLine("sC[sC.Length - i - 1]:{0}  sC[sC.Length - i - 2]:{1}  Diff{2}",
                //       (int)sC[sC.Length - i - 1], (int)sC[sC.Length - i - 2], (int)sC[sC.Length - i - 1] - (int)sC[sC.Length - i - 2]);
                if (sRArr[i] != sArr[i])
                {
                    status = false;
                    break;
                }
            }
            if (status) return ("Funny");
            else return ("Not Funny");
        }
        private static int Modulus(int x)
        {
            if (x < 0)
                return x * -1;
            return x;
        }
    }
}
