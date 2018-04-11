using System;
using System.Collections.Generic;
using System.Linq;

namespace as224wq_examination_1
{
    static class Statistics
    {

      public static dynamic DescriptiveStatistic(int[] source)
      {
        int maxValue = Maximum(source);
        Console.WriteLine("Maximum: " + maxValue);

        int minValue = Minimum(source);
        Console.WriteLine("Minimum: " + minValue);

        double averageValue = Mean(source);
        Console.WriteLine("Medelvärde: " + Math.Round(averageValue, 1));

        double medianValue = Median(source);
        Console.WriteLine("Median: " + Math.Round(medianValue, 1));

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
        Console.WriteLine("Typvärdet: " + resultString); 

        int rangeValue = Range(source);
        Console.WriteLine("Variationsbredd: " + rangeValue);

        double StandardDeviationValue = StandardDeviation(source);
        Console.WriteLine ("Standardavvikelse: " + Math.Round(StandardDeviationValue, 1));


        return null;
      }
      static int Maximum(int[] source)
      {
        int maxValue = source.Max();
        return maxValue;
      }
      static int Minimum(int[] source)
      {
        int minValue = source.Min();
        return minValue;
      }
      static double Mean(int[] source)
      {
        double averageValue = source.Average();
        return averageValue;
      } 
       static double Median(int[] source)
      {
     /*    if (source == null)
         throw new ArgumentNullException("source");
        var medianValue = source.OrderBy(n => n).ToArray();
        if (medianValue.Length == 0)
            throw new InvalidOperationException(); */
            var medianValue = source.OrderBy(n => n).ToArray();
        if (medianValue.Length % 2 == 0)
            return (medianValue[medianValue.Length / 2 - 1] + medianValue[medianValue.Length / 2]) / 2.0;
        return medianValue[medianValue.Length / 2];       
      } 
 
      static int[] Mode(int[] source)
      {
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
        Console.WriteLine("maxInDictionary: " + maxInDictionary);
        int[] modeArray= new int[source.Length];
        int counter = 0;

        foreach (KeyValuePair<int, int> entry in mode)
        {
          if(entry.Value == maxInDictionary)
          {
            modeArray[counter] = entry.Key;
            // Console.WriteLine(entry.Key + " " + entry.Value);
            counter++;
          }
        }
        return modeArray;
      }

      static int Range(int[] source)
      {
        int rangeValue =  (source.Max()) - (source.Min());
        return rangeValue;
      }

       static double StandardDeviation(int[] source, int buffer = 1)
      {
      if (source == null)
      { throw new ArgumentNullException("source"); }
 
      var data = source.ToList();
      var average = data.Average();
      var differences = data.Select(u => Math.Pow(average - u, 2.0)).ToList();
      var StandardDeviationValue =  Math.Sqrt(differences.Sum() / (differences.Count() - buffer));
      return StandardDeviationValue;
      }


    }
}
