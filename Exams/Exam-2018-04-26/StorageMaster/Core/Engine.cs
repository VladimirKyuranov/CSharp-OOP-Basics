using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Core
{
    public static class Engine
    {
        public static void Run()
        {
            StorageMaster sm = new StorageMaster();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] commandArgs = input
                        .Split();
                    string command = commandArgs[0];
                    string result = string.Empty;

                    switch (command)
                    {
                        case "AddProduct":
                            {
                                string type = commandArgs[1];
                                double price = double.Parse(commandArgs[2]);
                                result = sm.AddProduct(type, price);
                                break;
                            }
                        case "RegisterStorage":
                            {
                                string type = commandArgs[1];
                                string name = commandArgs[2];
                                result = sm.RegisterStorage(type, name);
                                break;
                            }
                        case "SelectVehicle":
                            {
                                string name = commandArgs[1];
                                int garageSlot = int.Parse(commandArgs[2]);
                                result = sm.SelectVehicle(name, garageSlot);
                                break;
                            }
                        case "LoadVehicle":
                            {
                                IEnumerable<string> productNames = commandArgs.Skip(1);
                                result = sm.LoadVehicle(productNames);
                                break;
                            }
                        case "SendVehicleTo":
                            {
                                string sourceName = commandArgs[1];
                                int sourceGarageSlot = int.Parse(commandArgs[2]);
                                string destinationName = commandArgs[3];
                                result = sm.SendVehicleTo(sourceName, sourceGarageSlot, destinationName);
                                break;
                            }
                        case "UnloadVehicle":
                            {
                                string storageName = commandArgs[1];
                                int garageSlot = int.Parse(commandArgs[2]);
                                result = sm.UnloadVehicle(storageName, garageSlot);
                                break;
                            }
                        case "GetStorageStatus":
                            {
                                string storageName = commandArgs[1];
                                result = sm.GetStorageStatus(storageName);
                                break;
                            }
                        default:
                            break;
                    }

                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    if (e.InnerException != null)
                    {
                        Console.WriteLine(e.InnerException.Message);
                    }
                    else
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            Console.WriteLine(sm.GetSummary());
        }
    }
}
