using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotProgram
{
    public class Fencing
    {
        public string plotInformation;
        public List<string> FencingRequired = new List<string>();
        public void getFencingNeededSingplePlot(List<Plot> plots)
        {
            
            foreach (Plot AreaPlot in plots)
            {
                plotInformation = String.Format("{0},{1},{2},{3} - {4}", AreaPlot.X, AreaPlot.Y, AreaPlot.H, AreaPlot.W,GetPerimeter(AreaPlot));
                FencingRequired.Add(plotInformation);
            }
            
        }

        public int GetTotalFencing(List<Plot> allPlots)
        {
            List<int> Xcoords = new List<int>();
            List<int> Ycoords = new List<int>();
            List<int> Y1coords = new List<int>();
            List<int> X1coords = new List<int>();// DO THIS
            for (int i = 0; i < allPlots.Count; i++)
            {
                Xcoords.Add(allPlots[i].X);
                Ycoords.Add(allPlots[i].Y);
                Y1coords.Add(allPlots[i].Y1);
            }
            int height = Ycoords.Max() - Y1coords.Min();
            int width = Xcoords.Max() - Xcoords.Min();
            int perimeter = 2 * (height + width);
            return perimeter;


        }
        public int GetPerimeter(Plot plot)
        {
            int Perimeter = 2 * (plot.H + plot.W);
            return Perimeter;
        }
    }
}
