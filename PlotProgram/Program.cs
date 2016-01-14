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
            Rotate rotate = new Rotate();
            Fertilize fertilizer = new Fertilize();

            string Choice = args[0];
            string allPlotsFile = args[1];
            string DestinationFile = args[2];
            
            int rotationAmount = 1;
            area.readInput(allPlotsFile);

            switch (Choice)
            {
                case "1":
                   
                    FileManager.WriteToFile(DestinationFile, area.GetOverlappedPlots());
                    break;
                case "2":
                    fencing.getFencingNeededSingplePlot(area.plots);
                    FileManager.WriteToFile(DestinationFile, fencing.FencingRequired);
                    break;
                case "3":
                    FileManager.WriteToFile(DestinationFile,fencing.GetTotalFencing(area.plots));
                    break;
                case "4":
                    float AmountRequired = fertilizer.getFertilizerNeeded( fertilizer.getTotalArea(area.plots));
                    FileManager.WriteToFile(DestinationFile, AmountRequired);
                    break;
                case"5":
                    area.readInput(allPlotsFile);
                    rotate.ItemToRotate(area.plots, rotationAmount);
                    FileManager.WriteFormattedString(DestinationFile, rotate.RotatedPlots);
                    break;
            }


           // Console.ReadLine();

        }
    }
}
