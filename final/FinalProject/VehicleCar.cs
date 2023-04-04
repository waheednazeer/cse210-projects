public class VehicleCar : Vehicle
{
    private string _passengerName;
    private string _travelDateTime;
    private string _seatNos;
    private string _passengerMobile;
    private List<string> _passengerList= new List<string>();
    private List<string> _seatsList = new List<string>
    {
        "SeatNo. 01 [ ]", "SeatNo. 02 [ ]", "SeatNo. 03 [ ]"
    };


    public VehicleCar()
    {

    }
    public VehicleCar(string vehicleType, int seatsAvailable) : base(vehicleType, seatsAvailable)
    {

    }
    public override void DisplayVehicleSeatList()
    {
       
        int line= 0;
        Console.Clear();
         Console.WriteLine("Available Seats: [ ] | Booked Seats: [X]\n");
        foreach (string seatnos in _seatsList)
        {
            Console.Write($" {seatnos} ");
            line++;
            if (line%6==0)
            {
                Console.WriteLine();
            }
        }

        Console.ReadLine();
    }
    public override void SetPassengerDetails()
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
    public override string GetPassengerName()
    {
        return _passengerName;
    }
    public override string GetTravelDate()
    {
        return _travelDateTime;
    }
    public override string GetBookedSeatNumber()
    {
        return _seatNos;
    }
    public override void SetBookedSeat()
    {
        string bookedSeat= GetBookedSeatNumber();
        for (int i=0; i< _seatsList.Count; i++)
        {
            
            
            if (_seatsList[i] =="SeatNo. "+bookedSeat+" [X]")
            {
                Console.WriteLine($"\nSeat No: {bookedSeat} already booked.");
                
            }
            if (_seatsList[i] =="SeatNo. "+bookedSeat+" [ ]")
            {
                _seatsList[i]="SeatNo. "+bookedSeat+" [X]";
            }
        }
        Console.ReadLine();
    }
    public override List<string> GetSeatList()
    {
        return _seatsList;
    }
    public override string GetPassengerDetails()
    {
        DateTime theCurrentTime= DateTime.Now;
        string dateText = theCurrentTime.ToString();
        return $"-----------------------------------\nBooking Date: {dateText}\nPassenger Name: {_passengerName} \nMobile: {_passengerMobile} Seat No: {_seatNos} \nTravel Date: {_travelDateTime}";
    } 
    public override void SetPassengerList()
    {
        string passenger= GetPassengerDetails();
        _passengerList.Add(passenger);

    } 

    public override List<string> GetPassengerList()
    {
        return _passengerList;
    }
}
