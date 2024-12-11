//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1157
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            input = input.ToUpper();
//            char[] alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
//            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//            int max = 0;
//            int maxCount = 0;
//            for (int i = 0; i < input.Length; i++)
//            {
//                for (int j = 0; j < alpha.Length; j++)
//                {
//                    if (input[i] == alpha[j])
//                    {
//                        count[j]++;

//                    }
//                }
//            }

//            for (int i = 0; i < count.Length; i++)
//            {
//                if (max < count[i])
//                {
//                    max = count[i];
//                }
//            }

//            for (int i = 0; i < count.Length; i++)
//            {
//                if (count[i] == max)
//                {
//                    maxCount++;
//                }
//            }
//            if (maxCount > 1)
//            {
//                Console.WriteLine("?");

//            }
//            else if (maxCount == 1)
//            {
//                for (int i = 0; i < alpha.Length; i++)
//                {
//                    if (count[i] == max)
//                    {
//                        Console.Write(alpha[i]);
//                    }
//                }
//            }
//        }
//    }
//}

