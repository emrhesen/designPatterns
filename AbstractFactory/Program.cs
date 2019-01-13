using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var  BmwCarManager = new CarManager(new BMWCarFactory());
            var  AudiCarManager = new CarManager(new AudiCarFactory());

            BmwCarManager.CreateCar();

            AudiCarManager.CreateCar();

            Console.ReadKey();
        }
    }

  
    public abstract class Car
    {
        public abstract void GetCar();
    }

    // Concrete Car
    public class BMWCar : Car
    {
        public override void GetCar()
        {
            Console.WriteLine("BMW Car Created");
        }
    }

    // Concrete Car
    public class AudiCar : Car
    {
        public override void GetCar()
        {
            Console.WriteLine("Audi Car Created");
        }
    }

    // Concrete Car
    public class MercedesCar : Car
    {
        public override void GetCar()
        {
            Console.WriteLine("Mercedes Car Created");
        }
    }


    public abstract class CarFactory
    {
        public abstract Car CarCreator();
    }

    // Concrete Factory
    public class BMWCarFactory : CarFactory
    {
        public override Car CarCreator()
        {
            return new BMWCar();
        }
    }

    // Concrete Factory
    public class AudiCarFactory : CarFactory
    {
        public override Car CarCreator()
        {
            return new AudiCar();
        }
    }

    // Concrete Factory
    public class MercedesCarFactory : CarFactory
    {
        public override Car CarCreator()
        {
            return new MercedesCar();
        }
    }

    // Factory Manager
    public class CarManager
    {
        //private readonly CarFactory _carFactory;
        private readonly Car _car;

        public CarManager(CarFactory carFactory)
        {
            //_carFactory = carFactory;
            _car = carFactory.CarCreator();
        }

        public void CreateCar()
        {
            _car.GetCar();
        }

    }
}
