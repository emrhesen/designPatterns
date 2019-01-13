using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var petrolEngine = new PetrolEngine { FuelType = "Petrol Engine" , OilPump = 1 , Piston = 4 , SparkPlug = 4 };

            // Clone object new reference
            var petrolEngine2 = (PetrolEngine)petrolEngine.Clone();
            petrolEngine2.Piston = 6;

            Console.WriteLine("Piston : {0}", petrolEngine.Piston); // Expected -> 4
            Console.WriteLine("Piston : {0}" , petrolEngine2.Piston); // Expected -> Piston : 6

            Console.ReadKey();
        }
    }

    // Prototype
    public abstract class CarEngine
    {
        public int Piston { get; set; }
        public int SparkPlug { get; set; }
        public int OilPump { get; set; }
        public abstract CarEngine Clone();
    }

    // Concrete Class
    public class PetrolEngine : CarEngine
    {
        public string FuelType { get; set; }

        public override CarEngine Clone()
        {
            return (CarEngine)MemberwiseClone();
        }
    }
}
