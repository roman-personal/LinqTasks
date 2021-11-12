﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTasks {
    static class Task4 {
        public static void Run() {
            Console.WriteLine("Task4");

            Entry[] entries = {
                new Entry() { Name = "John", Phone = "+7(915)555-31-23", IsPortable = true},
                new Entry() { Name = "ann", Phone = "+7(920)432-18-66", IsPortable = true},
                new Entry() { Name = "Hovard", Phone = "+7(4872)55-11-53", IsPortable = false},
                new Entry() { Name = "Peter", Phone = "+7(910)155-91-73", IsPortable = true},
            };

            var query = entries.Where(x => x.IsPortable)
                .OrderBy(x => x.Name, StringComparer.CurrentCultureIgnoreCase)
                .Zip(Enumerable.Range(1, int.MaxValue), (x, i) => $"{i}) {x.Name} - {x.Phone}");

            foreach (string str in query)
                Console.WriteLine(str);
        }
    }

    class Entry {
        public string Name { get; set; } // имя абонента
        public string Phone { get; set; } // номер телефона
        public bool IsPortable { get; set; } // это мобильный телефон
    }
}
