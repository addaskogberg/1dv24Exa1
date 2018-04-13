using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace as224wq_examination_1
{
    class Program
    {
        static void Main(string[] args) 
        {    
            //Json filen görs om till en int array           
            var json = File.ReadAllText(@"data.json");
            var data = JsonConvert.DeserializeObject<List<int>>(json);  
            int[] source = new int[data.Count];

            for(int i = 0; i < data.Count ; i ++)
            {
                source [i] = data[i];
            }

           // source = null;  används för att testa exceptions

            //kallar på metoden DescriptivStatistics och skriver ut värdena
            Console.WriteLine(Statistics.DescriptiveStatistic(source));      
       }
   }
}
