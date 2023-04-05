using System;


public class VehicleMenu
{
    private List<string> _mainMenu;
    private List<string> _withinCityMenu;
    private List<string> _outsideCityMenu;
    private List<string> _bookingPrintingMenu;

    public VehicleMenu()
    {
        _mainMenu = new List<string>
        {
            "Menu Options:",
            "  1. Travel within City",
            "  2. Travel outside City",
            "  3. Quit"
        };


        _withinCityMenu = new List<string>
        {
            "Do you want to book MiniCar or Bike:",
            "   1. Select MiniCar",
            "   2. Select Bike",
        };

        _outsideCityMenu = new List<string>
        {
            "Please select your travelling prefererence:",
            "   1. Select Bus",
            "   2. Select MiniBus",
            "   3. Select Car"

        };
        
        _bookingPrintingMenu = new List<string>
        {
            "Do you want to book or print tickets:",
            "   1. Book Seat",
            "   2. Print Tickets"
           
        };
    }

    public void DisplayMainMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Vehicle Ticket Booking Application!\n");
        foreach (string menuItem in _mainMenu)
        {
            Console.WriteLine(menuItem);
        }

        Console.Write("Select a choice: ");
       
    }

    public void DisplayWithinCityMenu()
    {
        Console.Clear();
        foreach (string menuItem in _withinCityMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("Select a choice from the menu: ");
    }
    public void DisplayOutsideCityMenu()
    {
        Console.Clear();
        foreach (string menuItem in _outsideCityMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("Select a choice from the menu: ");
    }
        public void DisplayBookingMenu()
    {
        Console.Clear();
        foreach (string menuItem in _bookingPrintingMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("Select a choice from the menu: ");
    }

}