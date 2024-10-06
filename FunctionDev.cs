using System;
using System.Collections.Generic;
using System.Linq;

public class FunctionDev
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> answer = new List<int>();
        Queue<int> Q_progresses = new Queue<int>(progresses);
        Queue<int> Q_speeds = new Queue<int>(speeds);
        int complete = 0;

        while (Q_progresses.Count > 0)
        {
            for (int i = 0; i < Q_progresses.Count; i++)
            {
                int temp = Q_progresses.Dequeue();
                temp += Q_speeds.ToArray()[i];

                Q_progresses.Enqueue(temp);
            }


            while (Q_progresses.Peek() >= 100)
            {
                Q_progresses.Dequeue();
                Q_speeds.Dequeue();
                complete++;
                if (Q_progresses.Count == 0) break;
            }
            if (complete > 0)
            {
                answer.Add(complete);
                complete = 0;
            }
        }

        return answer.ToArray();
    }
}