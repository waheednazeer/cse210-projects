using System;

class Program
{
    static void Main(string[] args)
    {
       VehicleMenu menu= new VehicleMenu();
       VehicleFiles files= new VehicleFiles();
        Vehicle vehicle= null;
        
        string control="";
        string withinCityControl ="";
        string outsideCityControl ="";
        string bookingControl = "";

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
                       //-------------
                        vehicle = new VehicleMiniCar("MiniCar", 1);
                        menu.DisplayBookingMenu();
                        bookingControl= Console.ReadLine();
                        if (bookingControl == "1")
                        {
                            files.LoadFromFile("MiniCarSeats.txt", vehicle.GetSeatList());
                            Console.WriteLine();
                            vehicle.SetPassengerDetails();
                            if (vehicle.GetBookedSeatNumber() != "" && vehicle.GetBookedSeatNumber().Length == 2 && vehicle.GetPassengerName() != "" )
                            {
                            
                            vehicle.SetPassengerList();
                            vehicle.SetBookedSeat();
                            files.SavePassengerFile("MiniCarDriverList.txt",vehicle.GetPassengerList());  
                            files.SaveToFile("MiniCarSeats.txt",vehicle.GetSeatList());
                            }
                            else
                            {
                            Console.WriteLine("\n**Seat No. or Name can not be null**");
                            Console.ReadLine();
                            }
                        }
                        if (bookingControl == "2")
                        {
                            files.LoadPassengerFile("MiniCarDriverList.txt",vehicle.GetPassengerList());                         
                        } 
                       //-------------
                    }
                    if (withinCityControl == "2")
                    {
                        vehicle = new VehicleBike("Bike", 1);
                        menu.DisplayBookingMenu();
                        bookingControl= Console.ReadLine();
                        if (bookingControl == "1")
                        {
                            files.LoadFromFile("BikeSeats.txt", vehicle.GetSeatList());
                            Console.WriteLine();
                            vehicle.SetPassengerDetails();
                            if (vehicle.GetBookedSeatNumber() != "" && vehicle.GetBookedSeatNumber().Length == 2 && vehicle.GetPassengerName() != "" )
                            {
                            
                            vehicle.SetPassengerList();
                            vehicle.SetBookedSeat();
                            files.SavePassengerFile("BikeDriverList.txt",vehicle.GetPassengerList());  
                            files.SaveToFile("BikeSeats.txt",vehicle.GetSeatList());
                            }
                            else
                            {
                            Console.WriteLine("\n**Seat No. or Name can not be null**");
                            Console.ReadLine();
                            }
                        }
                        if (bookingControl == "2")
                        {
                            files.LoadPassengerFile("BikeDriverList.txt",vehicle.GetPassengerList());                         
                        } 
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

                    menu.DisplayBookingMenu();
                    bookingControl= Console.ReadLine();
                    if (bookingControl == "1")
                    {
                        files.LoadFromFile("BusSeats.txt", vehicle.GetSeatList());
                        
                        vehicle.SetPassengerDetails();
                        if (vehicle.GetBookedSeatNumber() != "" && vehicle.GetBookedSeatNumber().Length == 2 && vehicle.GetPassengerName() != "" )
                        {
                            
                            vehicle.SetPassengerList();
                            vehicle.SetBookedSeat();
                            files.SavePassengerFile("BusPassengerList.txt",vehicle.GetPassengerList());  
                            files.SaveToFile("BusSeats.txt",vehicle.GetSeatList());
                        }
                        else
                        {
                            Console.WriteLine("\n**Seat No. or Name can not be null**");
                            Console.ReadLine();
                        }
                    }
                    if (bookingControl == "2")
                    {
                        files.LoadPassengerFile("BusPassengerList.txt",vehicle.GetPassengerList());                         
                    }   
                }

                if (outsideCityControl== "2")
                {

                    vehicle = new VehicleMiniBus("MiniBus", 12);
                    menu.DisplayBookingMenu();
                    bookingControl= Console.ReadLine();
                    if (bookingControl == "1")
                    {
                        files.LoadFromFile("MiniBusSeats.txt", vehicle.GetSeatList());
                        vehicle.SetPassengerDetails();
                        if (vehicle.GetBookedSeatNumber() != "" && vehicle.GetBookedSeatNumber().Length == 2 && vehicle.GetPassengerName() != "" )
                        {
                            
                            vehicle.SetPassengerList();
                            vehicle.SetBookedSeat();
                            files.SavePassengerFile("MiniBusPassengerList.txt",vehicle.GetPassengerList());  
                            files.SaveToFile("MiniBusSeats.txt",vehicle.GetSeatList());
                        }
                        else
                        {
                            Console.WriteLine("\n**Seat No. or Name can not be null**");
                            Console.ReadLine();
                        }
                    }
                    if (bookingControl == "2")
                    {
                        files.LoadPassengerFile("MiniBusPassengerList.txt",vehicle.GetPassengerList());                         
                    }   
                }

                if (outsideCityControl == "3")
                {

                    vehicle = new VehicleCar("Car", 3);
                    menu.DisplayBookingMenu();
                    bookingControl= Console.ReadLine();
                    if (bookingControl == "1")
                    {
                        files.LoadFromFile("CarSeats.txt", vehicle.GetSeatList());
                        Console.WriteLine();
                        vehicle.SetPassengerDetails();
                        if (vehicle.GetBookedSeatNumber() != "" && vehicle.GetBookedSeatNumber().Length == 2 && vehicle.GetPassengerName() != "" )
                        {
                            
                            vehicle.SetPassengerList();
                            vehicle.SetBookedSeat();
                        files.SavePassengerFile("CarPassengerList.txt",vehicle.GetPassengerList());  
                        files.SaveToFile("CarSeats.txt",vehicle.GetSeatList());
                        
                        }
                        else
                        {
                            Console.WriteLine("\n**Seat No. or Name can not be null**");
                            Console.ReadLine();
                        }
                    }
                    if (bookingControl == "2")
                    {
                        files.LoadPassengerFile("CarPassengerList.txt",vehicle.GetPassengerList());                         
                    }   
                }
            }
        }
    }
    
}