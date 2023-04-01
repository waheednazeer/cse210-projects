public class VehicleMiniBus : Vehicle
{
    private List<string> _seatsList = new List<string>
    {
        "SeatNo. 01 [ ]", "SeatNo. 02 [ ]", "SeatNo. 03 [ ]", "SeatNo. 04 [ ]", "SeatNo. 05 [ ]", "SeatNo. 06 [ ]",
        "SeatNo. 07 [ ]", "SeatNo. 08 [ ]", "SeatNo. 09 [ ]", "SeatNo. 10 [ ]", "SeatNo. 11 [ ]", "SeatNo. 12 [ ]",
    };


    public VehicleMiniBus()
    {

    }
    public VehicleMiniBus(string vehicleType, int seatsAvailable) : base(vehicleType, seatsAvailable)
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
}