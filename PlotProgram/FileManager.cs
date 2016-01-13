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

            //foreach (string plot in plotCoordinates)
            //{
            //    using (StreamWriter writer = new StreamWriter(fileName, true))
            //    {
            //        writer.WriteLine(plot);
            //    }

            //}
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
