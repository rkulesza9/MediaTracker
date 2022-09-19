using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CCoreData.Initialize();

            Console.WriteLine(CCoreData.m_cData.m_cSeriesType.Count());

            Console.ReadLine();   
        }
    }
}
