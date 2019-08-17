using System;


namespace MilitaryUnit
{
    class App
    {
        public void Run()
        {
            //weapons
            var fiftyCal = new FiftyCal();
            var grenadeLauncher = new GrenadeLauncher();
            var m4 = new M4();
            var m9 = new M9();

            //vehicles
            var c130 = new C130();
            var c17 = new C17();
            var humv = new HUMV();
            var lmtv = new LMTV();

            //soldiers
            var specOps = new SpecOps();
            var regular = new Regular();
            var infantry = new Infantry();
            var pogs = new POGS();

            Console.WriteLine("These are the general specifications of components inside a Military Unit.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Weapons.");
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine($"The {fiftyCal.weaponName} has a caliber of {fiftyCal.weaponCaliber} with a weight of {fiftyCal.weaponWeight} pounds.");
            Console.WriteLine($"The {grenadeLauncher.weaponName} has a caliber of {grenadeLauncher.weaponCaliber} with a weight of {grenadeLauncher.weaponWeight} poundsb.");
            Console.WriteLine($"The {m4.weaponName} has a caliber of {m4.weaponCaliber} with a weight of {m4.weaponWeight} pounds.");
            Console.WriteLine($"The {m9.weaponName} has a caliber of {m9.weaponCaliber} with a weight of {m9.weaponWeight} pounds.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Vehicles");
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine($"The {c130.vehicleName} uses the fuel {c130.vehicleFuel} and can carry {c130.vehiclePassengers} people.");
            Console.WriteLine($"The {c17.vehicleName} uses the fuel {c17.vehicleFuel} and can carry {c17.vehiclePassengers} people.");
            Console.WriteLine($"The {humv.vehicleName} uses the fuel {humv.vehicleFuel} and can carry {humv.vehiclePassengers} people.");
            Console.WriteLine($"The {lmtv.vehicleName} uses the fuel {lmtv.vehicleFuel} and can carry {lmtv.vehiclePassengers} people.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Soldiers");
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine($"There is a soldier with the job of {specOps.soldierJob}");
            Console.WriteLine($"There is a soldier with the job of {regular.soldierJob}");
            Console.WriteLine($"There is a soldier with the job of {infantry.soldierJob}");
            Console.WriteLine($"There is a soldier with the job of {pogs.soldierJob}");
        }
    }
}
