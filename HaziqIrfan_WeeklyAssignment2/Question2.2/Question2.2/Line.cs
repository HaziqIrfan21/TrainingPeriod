using System;
using System.Collections.Generic;
using System.Text;

namespace Question2._2
{

   

    class Line
    {
        public float x1;
        public float x2;
        public float y1;
        public float y2;
        public float slope;


        public void Display(float startingX, float startingY, float endingX, float endingY)
        {
            x1 = startingX;
            y1 = startingY;
            x2 = endingX;
            y2 = endingY;
        }

        public void Slope(float endingY, float startingY, float endingX, float startingX)
        {
            slope = (endingY - startingY) / (endingX - startingX);
        }



    }
}
