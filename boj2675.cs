//using System;
//using System.Collections.Generic;

//namespace _2675
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int count = int.Parse(Console.ReadLine());
//            string[] input;

//            for (int i = 0; i < count; i++)
//            {
//                input = Console.ReadLine().Split(' ');
//                int repeatCount = int.Parse(input[0]);
//                string text = input[1];

//                List<string> result1 = new List<string>();

//                for (int j = 0; j < text.Length; j++)
//                {
//                    for (int x = 0; x < repeatCount; x++)
//                    {
//                        result1.Add(text[j].ToString());
//                    }
//                }

//                Console.WriteLine(string.Join("", result1));
//            }
//        }
//    }
//}
