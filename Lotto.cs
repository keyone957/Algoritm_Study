//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algorithm
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;

//    public class Lotto
//    {
//        public int[] solution(int[] lottos, int[] win_nums)
//        {
//            int right = 0;
//            int zero = 0;
//            int min = 0;//0을 제외하고 다른 값들을 비교했을때 이 값을 올리면 그게 최소값?
//            int max = 0;//0도 만일 정답일때 그게 최대로 맞았을때 맞는 순위


//            for (int i = 0; i < lottos.Length; i++)
//            {
//                if (lottos[i] == 0)
//                {
//                    zero++;
//                }
//                if (win_nums.Contains(lottos[i]))
//                {
//                    right++;
//                }
//            }
//            min = right;
//            max = zero + right;//0도 다 맞았을경우니 더해준다
//            int maxRank = max;
//            int minRank = min;
//            if (maxRank == 0)//6등때문에 넣은 if문
//                maxRank = 1;
//            if (minRank == 0)
//                minRank = 1;
//            int finalMaxRank = 7 - maxRank;//최종 순위 
//            int finalMinRank = 7 - minRank;
//            int[] answer = new int[] { finalMaxRank, finalMinRank };

//            return answer;
//        }
//    }
//}
