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
            Fencing fencing = new Fencing();
            string x = "3";
            switch (x)
            {
                case "1":
                    
                    string allPlots = "Plots.txt";  //args[1];
                    area.readInput(allPlots);
                    //area.GetOverlappedPlots();
                    string overlappinngFile = "OverlappingPlots.txt"; //args[2];
                    FileManager.WriteToFile(overlappinngFile, area.GetOverlappedPlots());
                    break;
                case "2":
                    allPlots = "Plots.txt";  //args[1];
                    //string fencingFile = args[2];
                    area.readInput(allPlots);
                    fencing.getFencingNeededSingplePlot(area.plots);
                    FileManager.WriteToFile("Fencing.txt", fencing.FencingRequired);
                    break;
                case "3":
                    allPlots = "Plots.txt";  //args[1];
                    //string fencingFile = args[2];
                    area.readInput(allPlots);
                    FileManager.WriteToFile("TotalFencing.txt",fencing.GetTotalFencing(area.plots));

                    break; 
            }


           // Console.ReadLine();

        }
    }
}
