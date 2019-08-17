namespace MilitaryUnit
{
    public class Vehicle : Unit
    {
        public string vehicleName;
        public string vehicleFuel;
        public double vehiclePassengers;

        public Vehicle(string name, string fuel, double passengers)
        {
            vehicleName = name;
            vehicleFuel = fuel;
            vehiclePassengers = passengers;
        }
    }
}
