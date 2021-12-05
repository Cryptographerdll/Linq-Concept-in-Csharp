using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Linq_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linq Property in C# .

            /// <summary>
            /// Linq to Sql;
            /// Linq to XML;
            /// Linq to Object;
            /// Linq to Dataset;
            /// Linq to Entity;
            /// </summary>

            ///
            /// Query Syntax 
            /// Non-Quuery Syntax
            ///

            /// Compare queries 

            List<string> Hi = new List<string>()
            {
                "khalil","bouhousse","home","speed","window","get","Slow","Server"
            };

            // Query Expression Concept .

            var Result = from item in Hi 
                         where item.Length > 3
                         select item;
        }
    }
}
