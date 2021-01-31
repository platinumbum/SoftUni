using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../words.txt");

            using (reader)
            {
                string[] words = reader.ReadToEnd().ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();
                Dictionary<string, int> counter = new Dictionary<string, int>();
                for (int i = 0; i < words.Length; i++)
                {
                    counter.Add(words[i], 0);
                }

                using(StreamReader inputReader = new StreamReader("../../../input.txt"))
                {
                    string[] searchedWords = inputReader.ReadToEnd().Split(new char[] { ' ', ',', '-', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();
                    for (int i = 0; i < searchedWords.Length; i++)
                    {
                        if (counter.ContainsKey(searchedWords[i]))
                        {
                            counter[searchedWords[i]]++;
                        }
                    }
                    using (StreamWriter wrirer = new StreamWriter("../../../output.txt"))
                    {
                        counter = counter.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);
                        foreach (var item in counter)
                        {
                            wrirer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }

                }
            }


        }
    }
}
