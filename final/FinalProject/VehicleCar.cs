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
       
        Console.Clear();
         Console.WriteLine("Available Seats: [ ] | Booked Seats: [X]\n");
        foreach (string seatnos in _seatsList)
        {
            Console.Write($" {seatnos} ");
            
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}