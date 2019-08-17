namespace MilitaryUnit
{
    public class Weapon : Unit
    {
        public string weaponName;
        public string weaponCaliber;
        public double weaponWeight;
        public Weapon(string name, string caliber, double weight)
        {
            weaponName = name;
            weaponCaliber = caliber;
            weaponWeight = weight;
        }
    }
}
