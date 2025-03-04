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
            book1.title = "janat k pate";
            book1.Author = "namra ahmad";
            book1.ISBN ="45676";
            book1.Price = 5000;

            book1.DisplayDatail();
            book1.ApplyDiscount(10);
        }
    }
}