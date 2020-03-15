using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ćwiczenia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zrobić statyczne klasy gdzie nie ma sensu inicjować obiektu (to raczej nie to samo co Singleton)
            DataReader dR = new DataReader(@"D:\_SZKOŁA\UE Katowice - Informatyka\SEM II\Systemy uczące się\Ćwiczenia\Ćwiczenia 2\gielda.txt");
            DecisionTable stockDecisionTable = dR.GetDataFromFile();

            double enthropy = Enthropy.GetEnthropyFromProbability(stockDecisionTable.Columns.Last().ValuesProbabilities);
            Console.WriteLine("Enthropy for decision attribute: {0:f3}", enthropy);

            Console.ReadKey();
        }

       
    }
}
