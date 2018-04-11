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
            var json = File.ReadAllText(@"data.json");
            var data = JsonConvert.DeserializeObject<List<int>>(json);  
            int[] source = new int[data.Count];

            for(int i = 0; i < data.Count ; i ++)
            {
                source [i] = data[i];
            }

            if (source == null)
            throw new ArgumentNullException("source");
            if (source.Length == 0)
            throw new InvalidOperationException();
            Statistics.DescriptiveStatistic(source);      
       }
   }
}
