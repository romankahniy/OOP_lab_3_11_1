using System;

namespace OOP_lab_3_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] sentences = str.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            int[] lengths = new int[sentences.Length];

            int maxLengthIndex = 0;

            int index = 0;

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                lengths[index] = words.Length;

                ++index;
            }

            for (int i = 0; i < lengths.Length; ++i)
            {
                Console.WriteLine("{0} речення має {1} слiв", i + 1, lengths[i]);
            }

            for (int i = 0; i < lengths.Length; ++i)
            {
                if (lengths[maxLengthIndex] <= lengths[i])
                {
                    maxLengthIndex = i;
                }
            }

            Console.WriteLine("\nНайдовше речення:\n{0}", sentences[maxLengthIndex]);

        }
    }
}
