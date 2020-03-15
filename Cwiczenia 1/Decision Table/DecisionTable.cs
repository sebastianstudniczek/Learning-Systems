using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia_1
{
    public class DecisionTable
    {
        public List<DecisionTableColumn> Columns { get;}
        public List<DecisionTableRow> Rows { get; }

        public Dictionary<object, List<object>> AttributeDecisions { get; set; }
        // Zastanawiać się czy zawsze używać i settera i gettera
        public int TableRowsCount { get; }
        public int TableColumnsCount { get; }

        private List<List<object>> _inputTable;
        public DecisionTable(List<List<object>> inputTable)
        {
            _inputTable = inputTable;

            TableRowsCount = inputTable.Count;
            TableColumnsCount = inputTable[0].Count;

            Columns = GetColumns();
            Rows = GetRows();
            AttributeDecisions = GetAttributeValuesDecisions();
        }

        private List<DecisionTableRow> GetRows()
        {
            List<DecisionTableRow> rows = new List<DecisionTableRow>();

            for (int i = 0; i < TableRowsCount; i++)
            {
                rows.Add(new DecisionTableRow(_inputTable[i]));
            }

            return rows;
        }

        private List<DecisionTableColumn> GetColumns()
        {
            List<DecisionTableColumn> columns = new List<DecisionTableColumn>();

            for (int i = 0; i < TableColumnsCount; i++)
            {
                List<object> temp = new List<object>();

                for (int j = 0; j < TableRowsCount; j++)
                {
                    temp.Add(_inputTable[j][i]);
                }

                columns.Add(new DecisionTableColumn(temp));
            }

            return columns;
        }

        private List<float> GetAttributesInformationFunctionValue()
        {
            Dictionary<object, List<object>> attributeValuesDecisions = new Dictionary<object, List<object>>();

            List<object> uniqueValues = Columns[0].Values.Distinct().ToList();

            List<object> uniqueDecisionValues = Columns.Last().Values.Distinct().ToList();

            List<List<object>> decisions = new List<List<object>>();

            uniqueValues.ForEach(
                x => decisions.Add(
                    Rows.Where(y => (y.Values).Contains(x)).Select(y => y.Values.Last()).ToList()));


            for (int i = 0; i < uniqueValues.Count; i++)
            {
                attributeValuesDecisions.Add(uniqueValues[i], decisions[i]);
            }

            // Obliczanie funkcji informacji dla atrybutu (columny)
            List<float> temp = new List<float>();

            foreach (var value in uniqueValues)
            {
                uniqueDecisionValues.ForEach(
                    x => temp.Add(
                        attributeValuesDecisions[value]
                        .FindAll(y => y.Equals(x)).Count() / attributeValuesDecisions[value].Count));
            }



            return 
        }

    }

}
