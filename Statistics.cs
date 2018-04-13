using System;
using System.Collections.Generic;
using System.Linq;

namespace as224wq_examination_1
{
    static class Statistics
    {
      // samlar ihop returerna i en public metod för utskrift i konsoll 
      public static dynamic DescriptiveStatistic(int[] source)
      {
        int maxValue = Maximum(source);
        String returnstring = "";
        returnstring += "Maximum: " + maxValue + "\n";
       
        int minValue = Minimum(source);
        returnstring += "Minimum: " + minValue + "\n";
      
        double averageValue = Mean(source);
        returnstring += "Medelvärde: " + Math.Round(averageValue, 1) + "\n";
     
        double medianValue = Median(source);
        returnstring += "Median: " + Math.Round(medianValue, 1) + "\n";
    
        int[] mode = Mode(source);
        string resultString = "";
        for(int i=0; i< mode.Length; i ++)
        {
          if(mode[i] != 0)
          {
            resultString += mode[i]+", ";
          }
        }
        resultString = resultString.Remove(resultString.Length -1);
        resultString = resultString.Remove(resultString.Length -1);
        returnstring += "Typvärdet: " + resultString + "\n";

        int rangeValue = Range(source);
        returnstring += "Variationsbredd: " + rangeValue + "\n";
       
        double StandardDeviationValue = StandardDeviation(source);
        returnstring += "Standardavvikelse: " + Math.Round(StandardDeviationValue, 1) + "\n";
    
        return returnstring;
      }


      // använder linq för att hitta maxvärdet i arrayen
      static int Maximum(int[] source)
      {
        checkForErrors(source);
        int maxValue = source.Max();
        return maxValue;
      }
       // använder linq för att hitta minvärdet i arrayen
      static int Minimum(int[] source)
      {
        checkForErrors(source);
        int minValue = source.Min();
        return minValue;
      }

       // använder linq för att hitta mmedelvärdet i arrayen
      static double Mean(int[] source)
      {
        checkForErrors(source);
        double averageValue = source.Average();
        return averageValue;
      } 

       // använder linq för att hitta medianvärdet i arrayen
       static double Median(int[] source)
      {
        checkForErrors(source);
            var medianValue = source.OrderBy(n => n).ToArray();
        if (medianValue.Length % 2 == 0)
            return (medianValue[medianValue.Length / 2 - 1] + medianValue[medianValue.Length / 2]) / 2.0;
        return medianValue[medianValue.Length / 2];       
      } 
 
       // använder inte linq för att hitta mode. Försökte men lyckades inte få till den. Ser gärna ett exempel på det. :)
       // använder i stället dictionary lägger in alla värden från arrayen till dictionary. finns värdet redan ökar antalet med 1
       // linq tar fram det värde med flest förekomster, vilket i det sammanhanget är typvärden (rad 98). vi går igenom dictionary igen och tittar vilka värden som är i max.
       // och lägger till dem i en ny array. Arrayen returneras.
      static int[] Mode(int[] source)
      {
        checkForErrors(source);
        Dictionary<int, int> mode = new Dictionary<int, int> { };
        int tempNo;
        for(int i = 0; i <source.Length; i++)
        {
          if(!mode.TryGetValue(source[i], out tempNo))
          {
            mode.Add(source[i], 1);
          }
          else
          {
            mode[source[i]]++;
          }
        }

        int maxInDictionary = mode.Values.Max();
        int[] modeArray= new int[source.Length];
        int counter = 0;

        foreach (KeyValuePair<int, int> entry in mode)
        {
          if(entry.Value == maxInDictionary)
          {
            modeArray[counter] = entry.Key;
            counter++;
          }
        }
        return modeArray;
      }

      // använder linq för att hitta maxvärdet  och minvärdet i arrayen för att få fram variationsbredden 
      static int Range(int[] source)
      {
        checkForErrors(source);
        int rangeValue =  (source.Max()) - (source.Min());
        return rangeValue;
      }

      // beräknar standardavvikelsen
       static double StandardDeviation(int[] source, int buffer = 1)
      { 
        checkForErrors(source);
        var data = source.ToList();
        var average = data.Average();
        var differences = data.Select(u => Math.Pow(average - u, 2.0)).ToList();
        var StandardDeviationValue =  Math.Sqrt(differences.Sum() / (differences.Count() - buffer));
        return StandardDeviationValue;
      }


      // hanterar exceptions en metod som används i varje beräknande metod ovan. 
      static void checkForErrors(int[] source)
      {
        if (source.Length == 0)
        { 
          throw new InvalidOperationException();
        }
        if (source == null)
        { 
          throw new ArgumentNullException("source"); 
        }
      }
    }
}
