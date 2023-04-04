public class VehicleBus : Vehicle
{
    private string _passengerName;
    private string _travelDateTime;
    private string _seatNos;
    private string _passengerMobile;
    private List<string> _passengerList= new List<string>();
    private List<string> _busSeatsList = new List<string>
    {
        "SeatNo. 01 [ ]", "SeatNo. 02 [ ]", "SeatNo. 03 [ ]", "SeatNo. 04 [ ]", "SeatNo. 05 [ ]", "SeatNo. 06 [ ]",
        "SeatNo. 07 [ ]", "SeatNo. 08 [ ]", "SeatNo. 09 [ ]", "SeatNo. 10 [ ]", "SeatNo. 11 [ ]", "SeatNo. 12 [ ]",
        "SeatNo. 13 [ ]", "SeatNo. 14 [ ]", "SeatNo. 15 [ ]", "SeatNo. 16 [ ]", "SeatNo. 17 [ ]", "SeatNo. 18 [ ]",
        "SeatNo. 19 [ ]", "SeatNo. 20 [ ]", "SeatNo. 21 [ ]", "SeatNo. 22 [ ]", "SeatNo. 23 [ ]", "SeatNo. 24 [ ]",
    };


    public VehicleBus()
    {

    }
    public VehicleBus(string vehicleType, int seatsAvailable) : base(vehicleType, seatsAvailable)
    {

    }
    public override void DisplayVehicleSeatList()
    {
       
        int line= 0;
        Console.Clear();
        Console.WriteLine("Available Seats: [ ] | Booked Seats: [X]\n");
        foreach (string seatnos in _busSeatsList)
        {
            Console.Write($" {seatnos} ");
            line++;
            if (line%6==0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();

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
        for (int i=0; i< _busSeatsList.Count; i++)
        {
            
            
            if (_busSeatsList[i] =="SeatNo. "+bookedSeat+" [X]")
            {
                Console.WriteLine($"\nSeat No: {bookedSeat} already booked.");
                
            }
            if (_busSeatsList[i] =="SeatNo. "+bookedSeat+" [ ]")
            {
                _busSeatsList[i]="SeatNo. "+bookedSeat+" [X]";
            }
        }
        Console.ReadLine();
    }
    public override List<string> GetSeatList()
    {
        return _busSeatsList;
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