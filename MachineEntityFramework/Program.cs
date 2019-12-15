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
            ReadLine();
            MachineDb.AddNewRecord(new Machine()
            {
                producer = "GarbagePC",
                machineType = "pc",
                price = 123.21f,
                flops = 432
            });
            ReadLine();
        }
    }
}
