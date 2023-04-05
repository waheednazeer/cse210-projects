
public class Vehicle
{
    private string _passengerName;
    private string _travelDateTime;
    private string _seatNos;
    private string _passengerMobile;
    private List<string> _passengerList= new List<string>();
    private int _seatsAvailable;
    private string _vehicleType;

    public Vehicle()
    {

    }
    public Vehicle(string vehicleType, int seatsAvailable)
    {
        _vehicleType = vehicleType;
        _seatsAvailable = seatsAvailable;
        
    }

    public string GetVehicleType()
    {
        return _vehicleType;
    }
    public int GetSeatsAvailable()
    {
        return _seatsAvailable;
    }
//--------all same methods
public virtual void DisplayVehicleSeatList()
    {


    }

      public virtual void SetPassengerDetails()
    {
        //Console.Clear();
        string passengerName, travelDateTime, seatNos, passengerMobile;
        Console.Write("Please enter passenger name: ");
        passengerName = Console.ReadLine();
        _passengerName = passengerName;
        Console.Write("Please enter passenger mobile no: ");
        passengerMobile = Console.ReadLine();
        _passengerMobile = passengerMobile;
        Console.Write("Please enter travel date and time: ");
        travelDateTime = Console.ReadLine();
        _travelDateTime = travelDateTime;
        Console.Write("Please enter seat no: ");
        seatNos = Console.ReadLine();
        _seatNos = seatNos;
    }
    public virtual string GetPassengerName()
    {
        return _passengerName;
    }
    public virtual string GetTravelDate()
    {
        return _travelDateTime;
    }
    public virtual string GetBookedSeatNumber()
    {
        return _seatNos;
    }
    public virtual void SetBookedSeat()
    {

    }
    public virtual List<string> GetSeatList()
    {
        return new List<string>();
    }
    public virtual string GetPassengerDetails()
    {
        DateTime theCurrentTime= DateTime.Now;
        string dateText = theCurrentTime.ToString();
        return $"-----------------------------------\nBooking Date: {dateText}\nPassenger Name: {_passengerName} \nMobile: {_passengerMobile} Seat No: {_seatNos} \nTravel Date: {_travelDateTime}";
    } 
    public virtual void SetPassengerList()
    {
        string passenger= GetPassengerDetails();
        _passengerList.Add(passenger);

    } 

    public virtual List<string> GetPassengerList()
    {
        return _passengerList;
    }   


//--------this is just testing 
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