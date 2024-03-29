public class VehicleBike : Vehicle
{
    private List<string> _seatsList = new List<string>
    {
        "Bike No. 01 [ ]", "Bike No. 02 [ ]", "Bike No. 03 [ ]", "Bike No. 04 [ ]", "Bike No. 05 [ ]", "Bike No. 06 [ ]"
    };


    public VehicleBike()
    {

    }
    public VehicleBike(string vehicleType, int seatsAvailable) : base(vehicleType, seatsAvailable)
    {

    }
public override void DisplayVehicleSeatList()
    {
       
        int line= 0;
        Console.Clear();
         Console.WriteLine("Available Bikes: [ ] | Booked Bikes: [X]\n");
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
            
            
            if (_seatsList[i] =="Bike No. "+bookedSeat+" [X]")
            {
                Console.WriteLine($"\nBike No: {bookedSeat} already booked.");
                
            }
            if (_seatsList[i] =="Bike No. "+bookedSeat+" [ ]")
            {
                _seatsList[i]="Bike No. "+bookedSeat+" [X]";
            }
        }
        Console.ReadLine();
    }
    public override List<string> GetSeatList()
    {
        return _seatsList;
    }

}