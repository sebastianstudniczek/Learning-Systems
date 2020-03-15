using System;
using System.Collections.Generic;
using System.Linq;

namespace Ćwiczenia_1
{
    class Enthropy
    { 
        public static double GetEnthropyFromProbability(List<float> attributeUniqueValuesProbabilities)
        {
            double enthropy = 0;

            foreach (var item in attributeUniqueValuesProbabilities)
            {
                enthropy += item * Math.Log(item, 2);
            }
            return -1 * enthropy;
        }

        //public static double GetEnthropyByDecisionClasses()
        //{

        //}
    }
}
