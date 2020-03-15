using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia_1
{
    class DataReader
    {
        private string _source;

        public DataReader(string source)
        {
            _source = source;
        }
        public DecisionTable GetDataFromFile()
        {
            List<List<object>> input = new List<List<object>>();

            string[] lines = System.IO.File.ReadAllLines(_source);

            foreach (var line in lines)
            {
                input.Add(
                    new List<object>(line.Split(',').ToList()));
            }

            return new DecisionTable(input);
        }
    }
}
