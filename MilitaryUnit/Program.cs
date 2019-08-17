using System.Collections.Generic;


namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            new App().Run();
        }
    }

    public class Mounted : Weapon
    {
        public Mounted(string name, string caliber, double weight) : base (name, caliber, weight)
        {
            weaponName = name;
            weaponCaliber = caliber;
            weaponWeight = weight;
        }
    }

    class Carried : Weapon
    {
        public Carried(string name, string caliber, double weight) : base (name, caliber, weight)
        {
            weaponName = name;
            weaponCaliber = caliber;
            weaponWeight = weight;
        }
    }

    public class Land : Vehicle
    {
        public Land(string name, string fuel, double passengers) : base(name, fuel, passengers)
        {
            vehicleName = name;
            vehicleFuel = fuel;
            vehiclePassengers = passengers;
        }
    }

    class Air : Vehicle
    {
        public Air(string name, string fuel, double passengers) : base(name, fuel, passengers)
        {
            vehicleName = name;
            vehicleFuel = fuel;
            vehiclePassengers = passengers;
        }
    }

    class Airborne : Soldiers
    {
        public Airborne(string job) : base(job)
        {

        }
    }

    class Legs : Soldiers
    {
        public Legs(string job) : base(job)
        {

        }
    }

    public class FiftyCal : Mounted
    {
  
        public FiftyCal() : base("M2 50 Cal Machine Gun", "50 Caliber", 42)
        {

        }
    }

    class GrenadeLauncher : Mounted
    {
        public GrenadeLauncher() : base("Mk 19 Grenade Launcher", "40MM", 78)
        {

        }
    }

    class M4 : Carried
    {
        public M4() : base("M4A1", "5.56", 6)
        {

        }
    }

    class M9 : Carried
    {
        public M9() : base("M9 Beretta", "9MM", 2)
        {

        }
    }

    public class HUMV : Land
    {
        public HUMV() : base("HUMV", "Diesel", 5)
        {

        }
    }

    class LMTV : Land
    {
        public LMTV() : base("LMTV", "Diesel", 19)
        {

        }
    }

    class C130 : Air
    {
        public C130() : base("C130", "JP8", 92)
        {

        }
    }

    class C17 : Air
    {
        public C17() : base("C17", "JP8", 102)
        {

        }
    }

    class SpecOps : Airborne
    {
        public SpecOps() : base("Operator")
        {

        }
    }

    class Regular : Airborne
    {
        public Regular() : base("Airborne Infantry")
        {

        }
    }

    class Infantry : Legs
    {
        public Infantry() : base("Basic Infantry")
        {

        }
    }

    class POGS : Legs
    {
        public POGS() : base("Literally nothing")
        {

        }
    }
}
