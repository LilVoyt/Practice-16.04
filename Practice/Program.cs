using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            array.Show();
            array.Show("Hello");

            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Avg());
            Console.WriteLine(array.Search(0));

            array.SortByParam(false);
            array.Show();
        }
    }
}
