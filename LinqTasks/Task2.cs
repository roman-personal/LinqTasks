using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTasks {
    static class Task2 {
        public static void Run() {
            Console.WriteLine("Task2");
            int[] values = { 1, 2, 3, 4, 5, 6 };
            var query = values.Rotate(8);
            Console.WriteLine(string.Join(", ", query));
        }
    }

    static class Task2Extensions {
        public static IEnumerable<int> Rotate(this IEnumerable<int> source, int n) {
            n %= source.Count();
            if (n == 0)
                return source;
            return source.Skip(n).Concat(source.Take(n));
        }
    }
}
