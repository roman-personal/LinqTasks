using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTasks
{
    static class Task1 {
        public static void Run() {
            Console.WriteLine("Task1");
            var query = Fact().Take(10);
            Console.WriteLine(string.Join(", ", query));
        }

        static IEnumerable<int> Fact() {
            int n = 1, acc = 1;
            while (true) {
                yield return acc;
                acc *= ++n;
            }
        }
    }
}
