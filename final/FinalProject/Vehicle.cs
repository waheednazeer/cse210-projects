
public class Vehicle
{
    private string _passengerName;
    private string _travelDateTime;
    private string _seatNos;
    private int _seatsAvailable;
    private int _seatsBooked;
    private string _vehicleType;

    public Vehicle()
    {

    }
    public Vehicle(string vehicleType, int seatsAvailable)
    {
        _vehicleType = vehicleType;
        _seatsAvailable = seatsAvailable;
        _seatsBooked = 0;
    }

    public string GetVehicleType()
    {
        return _vehicleType;
    }
    public int GetSeatsAvailable()
    {
        return _seatsAvailable;
    }
    public virtual void SetPassengerDetails()
    {
        //Console.Clear();
        string passengerName, travelDateTime, seatNos;
        Console.Write("Please enter passenger name: ");
        passengerName = Console.ReadLine();
        _passengerName = passengerName;
        Console.Write("Please travell date and time: ");
        travelDateTime = Console.ReadLine();
        _travelDateTime = travelDateTime;
        Console.Write("Please enter seat nos.: ");
        seatNos = Console.ReadLine();
        _seatNos = seatNos;
    }
    public virtual string GetPassengerDetails()
    {
        return "";
    }
     public virtual void DisplayVehicleSeatList()
    {
        
    }
    public virtual string GetPassengerName()
    {
        return "";
    }
    public virtual string GetTravelDate()
    {
        return "";
    }
    public virtual string GetBookedSeatNumber()
    {
        return "";
    }
    public virtual void SetBookedSeat()
    {

    }
        public virtual List<string> GetSeatList()
    {
        List<string> seatList=new List<string>();
        return seatList;
    }
    public virtual void SetPassengerList()
    {
        
    } 
    public virtual List<string> GetPassengerList()
    {
        List<string> passengerList=new List<string>();
        return passengerList;
    }

    public void PrintPassengerList(List<string> passengerList)
    {
        Console.Clear();
        foreach (string passenger in passengerList)
        {
            Console.WriteLine($"{passenger}");
        }
        Console.WriteLine(passengerList.Count); // for testing List length
        Console.ReadLine();
        
    }
}