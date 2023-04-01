
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
    public void SetPassengerDetails()
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
    public string GetPassengerDetails()
    {
        return $"Passenger Name: {_passengerName} \nTravell Date: {_travelDateTime} Seat Nos.: {_seatNos}";
    }
     public virtual void DisplayVehicleSeatList()
    {
        
    }
}