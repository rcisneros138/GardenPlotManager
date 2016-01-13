using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlotProgram
{
    class Area
    {
        
        public List<Plot> plots = new List<Plot>();
        public List<string> Overlaps = new List<string>();
        public Area()
        {
            
            plots = new List<Plot>();
            
        }

        public void readInput(string FileName)
        {
            foreach (string plot in File.ReadAllLines(FileName))
            {
                string[] coords = plot.Split(',');
                CreatePlot(coords);
            }
           
        }

        public void CreatePlot(string[] ArrayOfPlotPoints)
        {
            List<int> PlotPoints = new List<int>();
            for (int i = 0; i < ArrayOfPlotPoints.Length; i++)
            {
                PlotPoints.Add( Convert.ToInt32(ArrayOfPlotPoints[i]));
            }
            int X1Coord = (PlotPoints[0] + PlotPoints[3]);
            int Y1Coord = (PlotPoints[1] + PlotPoints[2]);
            Plot plot = new Plot(PlotPoints[0], PlotPoints[1], PlotPoints[2], PlotPoints[3], X1Coord, Y1Coord );
            
            plots.Add(plot);
        }
        
        public List<string> GetOverlappedPlots()
        {
            for (int i = 0; i < plots.Count; i++)
            {
                for (int j = 0; j < plots.Count; j++)
                {
                    if (i == j)
                    {

                    }
                    else
                    {
                        if (plots[i].X > plots[j].X1 || plots[i].X1 < plots[j].X || plots[i].Y > plots[j].Y1 || plots[i].Y1 < plots[j].Y)
                        {
                            // you have no overlapps 
                        }
                        else
                        {
                            string OverlappedPlotCoordinate = string.Format("{0},{1},{2},{3}", plots[i].X, plots[i].Y, plots[i].H, plots[i].W);
                            if (!Overlaps.Contains(OverlappedPlotCoordinate))
                            {
                                Overlaps.Add(OverlappedPlotCoordinate);
                            }
                            
                        }
                    }
                }

            }
            return Overlaps;
        }
    }
}
