using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "peere kamil";
            book1.Author = "namra ahmad";
            book1.ISBN ="9676";
            book1.Price = 500;

            book1.DisplayDatail();
            book1.ApplyDiscount(10);
        }
    }
}