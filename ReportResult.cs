using System;
using System.Collections.Generic;
using System.Linq;

public class ReportResult
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        report = report.Distinct().ToArray();
        Dictionary<string, int> result = new Dictionary<string, int>();
        Dictionary<string, List<string>> whoReport = new Dictionary<string, List<string>>();
        Dictionary<string, int> reportResult = new Dictionary<string, int>();


        for (int i = 0; i < id_list.Length; i++)
        {
            result.Add(id_list[i], 0);
            reportResult.Add(id_list[i], 0);
            whoReport[id_list[i]] = new List<string>();
        }

        for (int i = 0; i < report.Length; i++)
        {
            string[] id = report[i].Split(' ');
            result[id[1]]++;//신고받은 사람 횟수 출력
            whoReport[id[0]].Add(id[1]);
        }


        List<string> stop = new List<string>();
        for (int i = 0; i < result.Count; i++)
        {
            if (result.Values.ToArray()[i] >= k)
            {
                stop.Add(result.Keys.ToArray()[i]);
            }
        }


        foreach (var r in report)
        {
            var user = r.Split(' ')[0];
            var target = r.Split(' ')[1];
            foreach (var s in stop)
            {
                if (s == target)
                {
                    reportResult[user]++;
                }
            }
        }

        return reportResult.Values.ToArray();
    }
}