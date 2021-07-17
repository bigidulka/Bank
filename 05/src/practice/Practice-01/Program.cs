using System;
using System.Collections.Generic;

namespace UdincevBogdan.Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("��������� ���������� ���������� ���������� ���� �� ������� ������.");

            var words = new Dictionary<string, int>();

            foreach(var word in args)
            {
                word.ToLowerInvariant().Trim("!?,.-()@#$%^&*()_+=-{}[]<>/|\\".ToCharArray());
                if (words.ContainsKey(word)) words[word]++;
                else words.Add(word, 1);
            }

            Console.WriteLine("������� ����������: ");
            foreach(var key in words.Keys)
                Console.WriteLine($"- {key} - {words[key]}");
            Console.WriteLine($"����� ���������� ����: {args.Length}");
            Console.WriteLine($"���������� ���������� ����: {words.Keys.Count}");
        }
    }
}
