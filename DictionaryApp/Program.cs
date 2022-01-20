using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "One");
            dic.Add(2, "Two");
            dic.Add(3, "Three");
            dic.Add(4, "Four");

            bool isExists = dic.ContainsValue("One");
            //Console.WriteLine(isExists);
            Console.WriteLine(dic[2]);

            foreach (KeyValuePair<int, string> valuePair in dic)
            {
                Console.WriteLine(valuePair.Key + " " + valuePair.Value);

            }
            Console.ReadLine();
        }
    }
}
