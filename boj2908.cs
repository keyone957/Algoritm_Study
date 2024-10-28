//using System;
//using System.Linq;

//namespace _2908
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            string[] inputs = input.Split();

//            if (inputs.Length != 2)
//            {
//                Console.WriteLine("입력된 숫자가 두 개가 아닙니다.");
//                return;
//            }

//            string aStr = inputs[0];
//            string bStr = inputs[1];

//            // 0 포함 여부 확인
//            if (aStr.Contains("0") || bStr.Contains("0"))
//            {
//                Console.WriteLine("0이 포함 되어있음 다시 하세요");
//                return;
//            }

//            // 뒤집기
//            string tempA = new string(aStr.ToCharArray().Reverse().ToArray());
//            string tempB = new string(bStr.ToCharArray().Reverse().ToArray());

//            // 문자열을 숫자로 변환
//            if (!int.TryParse(tempA, out int a) || !int.TryParse(tempB, out int b))
//            {
//                Console.WriteLine("숫자로 변환할 수 없습니다.");
//                return;
//            }

//            // 더 큰 값 출력
//            if (a < b)
//            {
//                Console.WriteLine(b);
//            }
//            else
//            {
//                Console.WriteLine(a);
//            }
//        }
//    }
//}