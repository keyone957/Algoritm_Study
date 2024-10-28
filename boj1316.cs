//using System;

//namespace boj1316
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int count = int.Parse(Console.ReadLine());
//            string[] input = new string[count];
//            int groupWordCount = count; // 그룹 단어 수를 세기 위한 변수

//            for (int i = 0; i < count; i++)
//            {
//                input[i] = Console.ReadLine().ToLower(); // 입력을 소문자로 변환하여 저장
//            }

//            for (int i = 0; i < count; i++)
//            {
//                bool[] seen = new bool[26]; // 알파벳 등장 여부를 저장하는 배열
//                bool isGroupWord = true;

//                for (int j = 0; j < input[i].Length; j++)
//                {
//                    int charIndex = input[i][j] - 'a'; // 문자의 알파벳 순서 구하기

//                    // 이전에 나온 적 있는데 연속된 문자가 아니라면 그룹 단어가 아님
//                    if (seen[charIndex] && input[i][j] != input[i][j - 1])
//                    {
//                        isGroupWord = false;
//                        break;
//                    }

//                    seen[charIndex] = true; // 해당 문자를 본 적 있다고 표시
//                }

//                if (!isGroupWord)
//                {
//                    groupWordCount--; // 그룹 단어가 아니면 카운터에서 제외
//                }
//            }

//            Console.WriteLine(groupWordCount); // 최종 그룹 단어 개수 출력
//        }
//    }
//}
