using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, 0, 1, 2, -1, 4 };
            int n = arr.Length;
            List<int> arrList = arr.ToList();
            List<int[]> results = FindTriplets(arrList);
            foreach (var result in results)
            {
                foreach (var number in result)
                {
                    Console.Write(number + ",");
                }

                Console.WriteLine();
            }
        }

        public static List<int[]> FindTriplets(List<int> s)
        {
            HashSet<int> set = new HashSet<int>();
            List<int[]> results = new List<int[]>();
            s.Sort();

            for (int i = 0; i < s.Count - 1; i++)
            {
                if (i == 0 || s[i] != s[i - 1])
                {
                    set.Clear();
                    for (int j = i + 1; j < s.Count; j++)
                    {
                        int k = -(s[i] + s[j]);
                        if (set.Contains(k))
                            results.Add(new[] { s[i], s[j], k });
                        set.Add(s[j]);
                    }
                }
            }
            return results;
        }
    }
}
