using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTasks {
    class Program {
        static void Main(string[] args) {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        static void Task1() {
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

        static void Task2() {
            Console.WriteLine("Task2");
            int[] values = { 1, 2, 3, 4, 5, 6 };
            var query = values.Rotate(8);
            Console.WriteLine(string.Join(", ", query));
        }

        static void Task3() {
            Console.WriteLine("Task3");
            int[] values = { 3, 4, 2, 1, 5, 6 };
            var query = values.Where((x, i) => x % 2 == 0 && i % 2 != 0);
            Console.WriteLine(string.Join(", ", query));
        }

        static void Task4() {
            Console.WriteLine("Task4");

            Entry[] entries = {
                new Entry() { Name = "John", Phone = "+7(915)555-31-23", IsPortable = true},
                new Entry() { Name = "ann", Phone = "+7(920)432-18-66", IsPortable = true},
                new Entry() { Name = "Hovard", Phone = "+7(4872)55-11-53", IsPortable = false},
                new Entry() { Name = "Peter", Phone = "+7(910)155-91-73", IsPortable = true},
            };

            var query = entries.Where(x => x.IsPortable)
                .OrderBy(x => x.Name, StringComparer.CurrentCultureIgnoreCase)
                .Zip(Enumerable.Range(1, int.MaxValue), (x, i) => i + ") " + x.Name + " - " + x.Phone);

            foreach (string str in query)
                Console.WriteLine(str);
        }

        static void Task5() {
            //var query = workbook.Worksheets.SelectMany(x => x.Shapes
            //   .Flatten()
            //   .Where(s => s.ShapeType == ShapeType.Shape && s.ShapeText.HasText)
            //   .Select(s => s.ShapeText.Characters().Text));
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

    class Entry {
        public string Name { get; set; } // имя абонента
        public string Phone { get; set; } // номер телефона
        public bool IsPortable { get; set; } // это мобильный телефон
    }

}
