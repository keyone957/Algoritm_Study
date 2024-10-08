//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algorithm
//{
//    internal class boj5622
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                string input = Console.ReadLine();
//                List<int> result = new List<int>();
//                int count = 0;
//                for (int i = 0; i < input.Length; i++)
//                {
//                    if (input[i] == 'A' || input[i] == 'B' || input[i] == 'C')
//                    {
//                        result.Add(3);
//                    }
//                    if (input[i] == 'D' || input[i] == 'E' || input[i] == 'F')
//                    {
//                        result.Add(4);
//                    }
//                    if (input[i] == 'G' || input[i] == 'H' || input[i] == 'I')
//                    {
//                        result.Add(5);
//                    }
//                    if (input[i] == 'J' || input[i] == 'K' || input[i] == 'L')
//                    {
//                        result.Add(6);
//                    }
//                    if (input[i] == 'M' || input[i] == 'N' || input[i] == 'O')
//                    {
//                        result.Add(7);
//                    }
//                    if (input[i] == 'P' || input[i] == 'Q' || input[i] == 'R' || input[i] == 'S')
//                    {
//                        result.Add(8);
//                    }
//                    if (input[i] == 'T' || input[i] == 'U' || input[i] == 'V')
//                    {
//                        result.Add(9);
//                    }
//                    if (input[i] == 'W' || input[i] == 'X' || input[i] == 'Y' || input[i] == 'Z')
//                    {
//                        result.Add(10);
//                    }
//                }

//                for (int i = 0; i < result.Count; i++)
//                {
//                    count += result[i];
//                }
//                Console.WriteLine(count);
//                //=>다이얼 문제 

//            }
//        }
//    }

//}

