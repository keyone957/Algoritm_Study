//using System;

//namespace Algorithm
//{
//    internal class boj2941
//    {
//        static void Main(string[] args)
//        {
//            string[] alpah = new string[] { "c=", "c-", "cz", "dz=", "d-", "lj", "nj", "s=", "z=" };
//            string input = Console.ReadLine();
//            int count = 0;
//            int count1 = 0;

//            for (int i = 0; i < alpah.Length; i++)
//            {
//                if (input.Contains(alpah[i]))
//                {
//                    input = input.Replace(alpah[i], "a");
//                }
//            }
//            Console.WriteLine(input.Length);
//            //==> 2941번 문자 배열들 비교해서 치환하는 방법으로 구함
//        }
//    }
//}