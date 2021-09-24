using System;

namespace EarthQuake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Earthquake
    {
        string nameOfPlace;
        int intensityOfEarthquake;

        void earthquake(string name, int intensity)
        {
            nameOfPlace = name;
            intensityOfEarthquake = intensity;
        }
    }

    class Tsunami
    {
        void tsunami(float probability)
        {

        }
    }
}
