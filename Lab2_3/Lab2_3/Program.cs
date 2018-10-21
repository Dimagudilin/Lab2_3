using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    class Program
    {

        interface IPrint
        {
            void Print();
        }
        abstract class Figura
        {
            public string Type
            {
                get
                {
                    return this._Type;
                }
                protected set
                {
                    this._Type = value;
                }
            }
            string _Type;

            public abstract double Ploshad();
        }
        class Pramougolnik : Figura, IPrint
        {
            double a, b;
            public Pramougolnik(double a, double b)
            {
                this.a = a;
                this.b = b;
                this.Type = "Прямоугольник";
            }
            public Pramougolnik(double a)
            {
                this.a = a;
                this.b = b;
            }
            public override string ToString()
            {
                return "Длина равна " + a + ", Ширина равна " + b + ", "+this.Type + " Площадью " + Ploshad();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Ploshad()
            {
                return a * b;
            }
        }
        class Kvadrat : Pramougolnik, IPrint
        {
            double a;
            public Kvadrat(double a) : base(a)
            {
                this.a = a;
                this.Type = "Квадрат";
            }
            public override string ToString()
            {
                return "Длина равна " + a + ", " + this.Type + " Площадью " + Ploshad();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Ploshad()
            {
                return a * a;
            }
        }
        class Krug : Figura, IPrint
        {
            double a;
            public Krug(double a)
            {
                this.a = a;
                this.Type = "Круг";
            }
            public override string ToString()
            {
                return "Радиус равен " + a + ", " + this.Type + " Площадью " + Ploshad();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Ploshad()
            {
                return 3.14 * a * a;
            }
        }
        static void Main(string[] args)
        {
            Krug krug = new Krug(5);
            Kvadrat kvadrat = new Kvadrat(5);
            Pramougolnik pramougolnik = new Pramougolnik(5, 6);
            krug.Print();
            kvadrat.Print();
            pramougolnik.Print();
            Console.ReadKey();
        }
    }
}
