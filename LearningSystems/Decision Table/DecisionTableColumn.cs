using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia_1
{
    public class DecisionTableColumn
    {
        public List<object> Values { get; set; }
        public List<float> ValuesProbabilities { get; }

        public DecisionTableColumn(List<object> values)
        {
            Values = values;
            ValuesProbabilities = GetAttributeValuesProbabilities();
        }

        private List<float> GetAttributeValuesProbabilities()
        {
            List<float> attributeUniqueValuesProbabilities = new List<float>();
            List<object> attributeUniqueValues = Values.Distinct().ToList();

            //Dictionary<object, int> attributeUniqueValuesOccurance = new Dictionary<object, int>();

            // Do i need dictionary for this?
            //attributeUniqueValues.ForEach(
            //    x =>
            //    attributeUniqueValuesOccurance.Add(x, Values.Where(y => y == x).Count()));
            attributeUniqueValues.ForEach(
                x =>
                attributeUniqueValuesProbabilities
                .Add(Values.Where(y => y.Equals(x)).Count() / (float)Values.Count));

            return attributeUniqueValuesProbabilities;
        }

    }
}
