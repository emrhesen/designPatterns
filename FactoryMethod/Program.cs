﻿using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Need IOC Container
            var carManager = new CarManager(new BugattiFactory());

            carManager.CreateCar();

            Console.ReadKey();
        }
    }

    public interface ICarFactory
    {
        ICar CreateCar();
    }
    public interface ICar
    {

    }

    public class BMWFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Bmw();
        }
    }

    public class BugattiFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Bugatti();
        }
    }

    public class Bmw : ICar
    {
        public Bmw()
        {
            Console.WriteLine("BMW Max Speed : 250 KM/H");
        }
    }

    public class Bugatti : ICar
    {
        public Bugatti()
        {
            Console.WriteLine("Bugatti Max Speed : 400 KM/H");
        }
    }

    public class CarManager
    {
        private readonly ICarFactory carFactory;

        public CarManager(ICarFactory _carFactory)
        {
            carFactory = _carFactory;
        }

        public void CreateCar()
        {
            carFactory.CreateCar();
        }
    }
}
