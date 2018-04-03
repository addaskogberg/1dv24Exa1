using System;
using System.IO;
using Newtonsoft.Json;

namespace as224wq_examination_1
{
    class Program
    {
        static void Main(string[] args)
        {

             var json = File.ReadAllText("data.json");
            var data = JsonConvert.DeserializeObject<string>(json); 
          
            Console.WriteLine(string.Join(",", data));
        }
    }
}
