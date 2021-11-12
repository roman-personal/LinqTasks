using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTasks
{
    // Напишите функцию IEnumerable<int> Fact() возвращающую последовательность значений 1!, 2!, 3!, 4! и т.д.
    // Выведите на консоль последовательность от 1! до 10!

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
