using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTasks {
    // Написать запрос возвращающий текст всех шейпов на всех листах книги
    // Не возвращать пустые строки для шейпов не содержащих текста
    // Возвращать текст в том числе для шейпов включенных в группы
    // Использовать метод API Flatten()

    static class Task5 {
        public static void Run() {
            Console.WriteLine("Task5");

            //var query = workbook.Worksheets.SelectMany(x => x.Shapes
            //   .Flatten()
            //   .Where(s => s.ShapeType == ShapeType.Shape && s.ShapeText.HasText)
            //   .Select(s => s.ShapeText.Characters().Text));
        }
    }
}
