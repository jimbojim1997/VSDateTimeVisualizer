using System;
using System.Diagnostics;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Debugger.Break();
        }
    }
}
