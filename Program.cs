using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var colletion = new List<string>
            {
                "Shekspir","Tom Kruz","Never to Die"
            };
            var selectedBook = new List<string>();
            foreach (var book in colletion)
            {
                if (book.ToLower().Contains("a"))
                    selectedBook.Add(book);
            }

            var plainResult = from book in colletion where book.ToLower().Contains("a") select book;
        }
    }
}
