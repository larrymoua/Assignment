using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate int averages(int number);
        static void Main(string[] args)
        {
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var hasTh = words.Where(w => w.Contains("th"));
            //foreach (string word in hasTh)
            //{
            //    Console.WriteLine(word);
            //    Console.ReadLine();
            //}

            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var removeDuplicates = names.Distinct();
            //foreach(var name in removeDuplicates)
            //{
            //    Console.WriteLine(name);
            //    Console.ReadLine();
            //}

            //Problem 3
            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            var numbers = classGrades.ConvertAll(n => n.Split(',').ToList());
            List<double> hi = new List<double>();
            List<double> finalnUmbers = new List<double>();
            foreach (List<string> strings in numbers)
            {           
                var convertedStrings = strings.ConvertAll(x => Convert.ToDouble(x));
                var newnew = convertedStrings.OrderBy(x => x);
                convertedStrings.RemoveAt(4);
                var added = convertedStrings.Sum(a => a);
                added = added / 4;
                hi.Add(added);              
            }
            var total = hi.Sum(s => s);
            double answer = total / 4;
            Console.WriteLine(answer);
            Console.ReadLine();
        }
        public static string letterFrequency(string word)
        {
            char[] a = word.ToCharArray();
            var result = a.OrderBy(al => new string(al.ToString().Reverse().ToArray()));

            List<string> newstring = new List<string>();
            string temp = "";

            newstring.Distinct();
            int count = 0;
            foreach (char c in result)
            {
                temp = Convert.ToString(c);
                for (int i = 0; i < a.Length; i++)
                {

                    if (c.Equals(a[i]))
                    {
                        count++;
                    }
                }
                Convert.ToString(count);
                temp += count;
                newstring.Add(temp);

                count = 0;
            }
            temp = "";
            var repearedThings = newstring.Distinct();
            foreach (string letters in repearedThings)
            {
                temp += letters;
            }

            return temp;

        }
    }
}

