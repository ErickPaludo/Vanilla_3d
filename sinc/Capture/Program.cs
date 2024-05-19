using Capture;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Data;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            int y = 2;
            Console.WriteLine($"{x} e {y}");
        }
    }
}