using System;

class Program
{
    static void Main(string[] args)
    {
       VehicleMenu menu= new VehicleMenu();
        Vehicle vehicle= null;
        
        string control="";
        string withinCityControl ="";
        string outsideCityControl ="";

        while (control != "3")
        {
            menu.DisplayMainMenu();
            control=Console.ReadLine();
            if (control == "1")
            {
                
                Console.Write("Do you have driving license? reply y/n: ");
                string license= Console.ReadLine();
                if(license == "y")
                {
                    
                    menu.DisplayWithinCityMenu();
                    withinCityControl=Console.ReadLine();
                    if (withinCityControl == "1")
                    {
                        vehicle= new VehicleCar("Car", 4);
                        vehicle.SetPassengerDetails();
                        Console.WriteLine(vehicle.GetPassengerDetails());
                        Console.ReadLine();
                    }
                    if (withinCityControl == "2")
                    {
                        vehicle= new VehicleCar("Bike", 2);
                        vehicle.SetPassengerDetails();
                        Console.WriteLine(vehicle.GetPassengerDetails());
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Sorry! without Driving License, you can not book car or bike.");
                    Console.ReadLine();
                }
            }
            if (control =="2")
            {
                menu.DisplayOutsideCityMenu();
                outsideCityControl= Console.ReadLine();
                if (outsideCityControl== "1")
                {
                    vehicle = new VehicleBus("Bus", 24);
                    vehicle.DisplayVehicleSeatList();
                    vehicle.SetPassengerDetails();
                    Console.WriteLine(vehicle.GetPassengerDetails());
                    Console.ReadLine();
                }
                if (outsideCityControl== "2")
                {
                    vehicle = new VehicleMiniBus("MiniBus", 12);
                    vehicle.DisplayVehicleSeatList();
                    vehicle.SetPassengerDetails();
                    Console.WriteLine(vehicle.GetPassengerDetails());
                    Console.ReadLine();
                }
                if (outsideCityControl == "3")
                {
                    vehicle = new VehicleCar("Car", 3);
                    vehicle.DisplayVehicleSeatList();
                    vehicle.SetPassengerDetails();
                    Console.WriteLine(vehicle.GetPassengerDetails());
                    Console.ReadLine();
                }
            }
        }
    }
    
}