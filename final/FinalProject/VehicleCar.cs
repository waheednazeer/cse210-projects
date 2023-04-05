public class VehicleCar : Vehicle
{
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

}
