using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < count; i++)
        {
            Stack<string> arr = new Stack<string>();
            string []input;
            input = Console.ReadLine().Split(" ");
            List<string> answer = new List<string>();
            for (int j = 0; j < input.Length; j++)
            {
                arr.Push(input[j]);
            }
            for (int a = 0; a < input.Length; a++)
            {
                answer.Add(arr.Pop());
            }
            Console.WriteLine($"Case #{i+1}: {string.Join(" ", answer)}");
        }
    }
}
