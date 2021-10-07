using System;

namespace EarthQuake
{
    class Program
    {
        static void Main(string[] args)
        {

            Earthquake earthQuake = new Earthquake();

            earthQuake.earthquake("Texas", 10);
            Console.WriteLine("Hello World!");
        }
    }

    class Earthquake :Tsunami
    {
        string nameOfPlace;
        int intensityOfEarthquake;

       public void earthquake(string name, int intensity)
        {
            nameOfPlace = name;
            intensityOfEarthquake = intensity;
        }
    }

    class Tsunami
    {
       public void CalculateTsunamiProbability(float probability,int intensity)
        {
            Random rnd = new Random();
            int rand = rnd.Next(intensity);
            probability = (float)(intensity * 0.7 + 0.3 * rand);
        }
    }
}
