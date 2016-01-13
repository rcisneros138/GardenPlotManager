using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotProgram
{
    class Fertilize
    {
        //public float AmountFertilizerRequired;
       // int totalLand;
        public float getTotalArea(List<Plot> plots)
        {
            float totalLand = 0;
            for (int i = 0; i < plots.Count; i++)
            {
               totalLand += (plots[i].H * plots[i].W);
            }
            return totalLand;
        }
        public float getFertilizerNeeded(float totalLand)
        {
            float AmoutFertilizerRequired = totalLand / 2;
            return AmoutFertilizerRequired;
        }

    }
}
