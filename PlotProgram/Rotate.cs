using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotProgram
{
    class Rotate
    {
        int height;
        int width;
        int Xcoordinate;
        int Ycoordinate;
        int X1coordinate;
        int Y1coordinate;
        public List<Plot> RotatedPlots = new List<Plot>();
        public void ItemToRotate(List<Plot> plots, int AmountOfRotations)
        {
            for (int i = 0; i < plots.Count; i++)
            {
                rotateNinetyDegrees(plots[i], AmountOfRotations);

            }
        }
        public void rotateNinetyDegrees(Plot plot, int counter)
        {
            
            for (int i = counter; i <= counter; i++)
            {
                Xcoordinate = plot.X;
                Ycoordinate = plot.Y;
                height = plot.W;
                width = plot.H;

                X1coordinate = plot.X + plot.W;
                Y1coordinate = plot.Y + plot.H;
            }

            Plot rotatedPlot = new Plot(Xcoordinate,Ycoordinate,height,width,X1coordinate,Y1coordinate);
            RotatedPlots.Add(rotatedPlot);


        }

       
    }
}
