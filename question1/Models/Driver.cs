using System;
using question1.Models;

namespace question1.Models
{
    public class Driver
    {
        public void startDriver(){
            BuildingCodes buildingCode = new();
            buildingCode.ListOfBuildingCodes.Add(new BuildingCodes(01, "Dorset Street", "0001A"));
            buildingCode.ListOfBuildingCodes.Add(new BuildingCodes(02, "Blessington Street", "0002F"));
            buildingCode.ListOfBuildingCodes.Add(new BuildingCodes(03, "Temple Bar Main Street", "0003H"));

            bool keepLoop = true;
                while (keepLoop)
                {
                    Console.WriteLine("Welcome to Local College System");
                    Console.WriteLine(" 1. List Buildings in Ascending Order");
                    Console.WriteLine(" 2. List Buildings in Descending Order");
                    Console.WriteLine(" 3. Add new Buildings Information");
                    Console.Write(" Option: ");
                    if (Int32.TryParse(Console.ReadLine(), out int menuOption))
                    {
                        switch (menuOption)
                        {
                            case 1:
                                keepLoop = false;
                                Console.WriteLine(" List Buildings in Ascending Order");
                                buildingCode.ListBuildingCodes();
                                break;
                            case 2:
                                keepLoop = false;
                                Console.WriteLine(" List Buildings in Descending Order");
                                buildingCode.ListBuildingCodes(false);
                                break;
                            case 3:
                                keepLoop = false;
                                Console.WriteLine(" Add Buildings Information");
                                BuildingCodes newBuildingInfo = new();
                                Console.WriteLine("Building ID: ");
                                newBuildingInfo.BuildingId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Building Location: ");
                                newBuildingInfo.BuildingLocation = Console.ReadLine();
                                Console.WriteLine("Building Code: ");
                                newBuildingInfo.BuildingCode = Console.ReadLine();
                                newBuildingInfo.ListOfBuildingCodes.Add(newBuildingInfo);
                                buildingCode.ListBuildingCodes();
                                break;
                            default:
                                keepLoop = true;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Please, enter a valid option");
                        Console.WriteLine();
                        keepLoop = true;
                    }

                }

        
        }

        
    }
}
