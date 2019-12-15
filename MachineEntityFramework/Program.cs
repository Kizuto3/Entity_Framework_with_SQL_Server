using MachineEntityFramework.DatabaseHelpers;
using MachineEntityFramework.EF;
using System;
using static System.Console;

namespace MachineEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Fun with Entity Framework");
            MachineDb.FindWithId(1);
            ReadLine();
        }
    }
}
