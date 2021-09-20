using System;
using System.Collections.Generic;
using System.Text;

namespace Question2._1
{
    class LandCalculator : Rectangle
    {
        public int totalcost;
       public void CalculateCost(int area, int pricePerFeet)
        {
            totalcost = area / pricePerFeet;
        }
    }
}
