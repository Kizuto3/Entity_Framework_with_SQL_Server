using MachineEntityFramework.EF;
using System;
using System.Collections.Generic;
using static System.Console;

namespace MachineEntityFramework.DatabaseHelpers
{
    class MachineDb
    {
        public static void PrintAllMachines()
        {
            using (var context = new MachineEntities())
            {
                try
                {
                    foreach (Machine machine in context.Machines)
                    {
                        WriteLine(machine);
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex.InnerException.Message);
                }
            }
        }

        public static void AddNewRecord(Machine machine)
        {
            using (var context = new MachineEntities())
            {
                try
                {
                    context.Machines.Add(machine);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    WriteLine(ex.InnerException.Message);
                }
            }
        }

        public static void AddRange(IEnumerable<Machine> machinesToAdd)
        {
            using (var context = new MachineEntities())
            {
                try
                {
                    context.Machines.AddRange(machinesToAdd);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    WriteLine(ex.InnerException.Message);
                }
            }
        }
    }
}
