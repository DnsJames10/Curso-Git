using System;
using System.Globalization;
using System.Collections.Generic;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2023, 01, 31, 15, 10, 11, DateTimeKind.Local);
            DateTime d1 = new DateTime(2023, 01, 31, 15, 10, 11, DateTimeKind.Utc);

            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToUniversalTime().ToShortTimeString());
        }
       
    }
}