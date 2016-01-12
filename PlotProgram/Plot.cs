using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotProgram
{
    public class Plot
    {
        public int X;
        public int Y;
        public int H;
        public int W;
        public int X1;
        public int Y1;
        public Plot(int Xcoord, int Ycoord, int Hcoord, int Wcoord, int X1coord, int Y1coord )
        {
            X = Xcoord;
            Y = Ycoord;
            X1 = X1coord;
            Y1 = Y1coord;
            H = Hcoord;
            W = Wcoord;
            
        }
        
    }
}
