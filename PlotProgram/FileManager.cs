using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlotProgram
{
    static class FileManager
    {
       
        public static void WriteToFile(string fileName, List<string> plotCoordinates)
        {
            
            foreach (string plot in plotCoordinates)
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.WriteLine(plot);
                }

            }
        }
        public static void WriteToFile(string fileName, int Item)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(Item);
            }

        
        }
        public static void WriteToFile(string fileName, float Item)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(Item);
            }


        }

        public static void WriteFormattedString(string fileName,List<Plot> plots)
        {
            for (int i = 0; i < plots.Count; i++)
            {
                string formattedCoords = string.Format("{0},{1},{2},{3}", plots[i].X, plots[i].Y, plots[i].H, plots[i].W);

                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.WriteLine(formattedCoords);
                }

            }
        }
        //public static string[] readInput(string FileName)
        //{
        //    string[] coords = new string[] { };
        //    foreach (string plot in File.ReadAllLines(FileName))
        //    {
        //         coords = plot.Split(',');

        //    }
        //    return coords;
        //}


    }
}
