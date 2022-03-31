using System;
namespace currency_and_degree
{
    public class Celcius
    {
        public double Degree { get; set; }
        public Celcius(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Celcius(Kelvin degr)
        {
            return new Celcius(degr.Degree -273);
        }
    }
}
