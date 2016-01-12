using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlotProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            string allPlots = "Plots.txt";//args[1];

            area.readInput(allPlots);
            area.removeNonOverlappedValues();

            foreach (string item in area.Overlaps)
            {
                Console.WriteLine(item);
            }

            //foreach (Plot plot in area.Overlaps)
            //{
            //    string OverlappedPlotCoordinate = string.Format("{0},{1},{2},{3}", plot.X, plot.Y, plot.H, plot.W);
            //    Console.WriteLine(OverlappedPlotCoordinate);
            //}
            //switch (args[0])
            //{
            //    case "1":
            //        string allPlots = "Plots.txt";//args[1];

            //        area.readInput(allPlots);
            //        //create and add to plot list
            //        //figured overlaps
            //        //write overlapps to file
            //        string overlappinngFile = args[2];

            //        break;

            //}





            Console.ReadLine();
            



        }
    }
}
