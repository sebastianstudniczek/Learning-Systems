using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia_1
{
    public class DecisionTableRow
    {
        public List<object> Values { get; }

        public object DecisionAttributeValue { get { return 
                    Values[Values.Count - 1]; } }

        public DecisionTableRow(List<object> values)
        {
            Values = values;

        }

        

    }
}
