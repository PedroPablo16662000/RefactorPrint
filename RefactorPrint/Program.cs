using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.PrintOrderedRowsAndColumns();
        }
    }
}
