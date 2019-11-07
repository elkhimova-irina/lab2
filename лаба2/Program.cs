
using System;
using System.Text;
using System.Threading.Tasks;


namespace лаба2
{
        interface IPrint
        {
            void Print();
        }

    abstract class GeomFigura
    {
        public string Figura { get; protected set; }

        public abstract double Area();
        public override string ToString()
        {
            return this.Figura + " площадью " + this.Area().ToString();
        }

    }


    class Rect : GeomFigura, IPrint
    {
        double height;
        double width;
        public Rect(double height, double width)
       {
            this.height = height;
            this.width = width;
            this.Figura = "Прямоугольник";
        }
        public override double Area()
        {
            return this.width * this.height;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Circle : GeomFigura, IPrint
        {
            double radius;
            public Circle(double pr)
            {
                this.radius = pr;
                this.Figura = "Круг";
            }

            public override double Area()
            {
                double Result = Math.PI * this.radius * this.radius;
                return Result;
            }
            public void Print()
            {
                Console.WriteLine(this.ToString());
            }
        }


    class Square : Rect, IPrint
    {
        public Square(double size)
            : base(size, size)
        {
            this.Figura = "Квадрат";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Elkhimova-irina ICS5-33B");
            Rect rect = new Rect(5, 4);
            rect.Print();
            Square square = new Square(9);
            square.Print();
            Circle circle = new Circle(3);
            circle.Print();
            
        }
    }
}


