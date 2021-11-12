using System;
using System.Linq;

namespace LinqTasks {
    static class Task3 {
        public static void Run() {
            Console.WriteLine("Task3");
            int[] values = { 3, 4, 2, 1, 5, 6 };
            var query = values.Where((x, i) => x % 2 == 0 && i % 2 != 0);
            Console.WriteLine(string.Join(", ", query));
        }
    }
}
