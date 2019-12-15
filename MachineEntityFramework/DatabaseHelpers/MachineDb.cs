using MachineEntityFramework.EF;
using System;
using System.Collections.Generic;
using static System.Console;
using MachineEntityFramework.Model;
using System.Linq;

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

        public static void PrintShortMachines()
        {
            using (var context = new MachineEntities())
            {
                foreach (ShortMachine shortMachine in context.Database.SqlQuery(typeof(ShortMachine), "Select id, producer from Machines"))
                {
                    WriteLine(shortMachine);
                }
            }
        }

        public static void FindWithProducer(string producer)
        {
            using (var context = new MachineEntities())
            {
                foreach (Machine machine in context.Machines.Where(m => m.producer.Equals(producer, StringComparison.OrdinalIgnoreCase)))
                {
                    WriteLine(machine);
                }
            }
        }
        public static void FindWithId(int id)
        {
            using (var context = new MachineEntities())
            {
                WriteLine(context.Machines.Find(id));
            }
        }
    }
}
