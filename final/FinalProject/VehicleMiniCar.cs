public class VehicleMiniCar : Vehicle
{
    private List<string> _seatsList = new List<string>
    {
        "MiniCar No. 01 [ ]", "MiniCar No. 02 [ ]", "MiniCar No. 03 [ ]", "MiniCar No. 04 [ ]", "MiniCar No. 05 [ ]", "MiniCar No. 06 [ ]"
    };


    public VehicleMiniCar()
    {

    }
    public VehicleMiniCar(string vehicleType, int seatsAvailable) : base(vehicleType, seatsAvailable)
    {

    }
public override void DisplayVehicleSeatList()
    {
       
        int line= 0;
        Console.Clear();
        Console.WriteLine("Available MiniCar: [ ] | Booked MiniCar: [X]\n");
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
            
            
            if (_seatsList[i] =="MiniCar No. "+bookedSeat+" [X]")
            {
                Console.WriteLine($"\nMiniCar No: {bookedSeat} already booked.");
                
            }
            if (_seatsList[i] =="MiniCar No. "+bookedSeat+" [ ]")
            {
                _seatsList[i]="MiniCar No. "+bookedSeat+" [X]";
            }
        }
        Console.ReadLine();
    }
    public override List<string> GetSeatList()
    {
        return _seatsList;
    }

}