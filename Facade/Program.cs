using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeManager = new ShapeManager();

            shapeManager.ShapeDrawer();

            Console.ReadLine();
        }
    }


    public interface IShape
    {
        void DrawShape();
    }

    public class Rectangle : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("Draw Shape : Rectangle");
        }
    }

    public class Square : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("Draw Shape : Square");
        }
    }

    public class Circle : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("Draw Shape : Circle");
        }
    }

    public class ShapeManager
    {
        private readonly ShapeFacade shapeFacade;
        public ShapeManager()
        {
            shapeFacade = new ShapeFacade();
        }


        public void ShapeDrawer()
        {
            shapeFacade.rectangle.DrawShape();
            shapeFacade.circle.DrawShape();
            shapeFacade.square.DrawShape();
        }

    }

    public class ShapeFacade
    {
        public IShape rectangle;
        public IShape square;
        public IShape circle;

        public ShapeFacade()
        {       // Use IoC Container 
            rectangle = new Rectangle();
            square = new Square();
            circle = new Circle();
        }
    }
}
