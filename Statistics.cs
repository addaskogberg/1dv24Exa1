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
        Console.WriteLine("Average: " + Math.Round(averageValue, 1));
        double medianValue = Median(source);
        Console.WriteLine("Median: " + Math.Round(medianValue, 1));
       /*  int[] modeValues = Mode(source);
        Console.WriteLine("Typvärdet: " + modeValues ); */
        int rangeValue = Range(source);
        Console.WriteLine("Range: " + rangeValue);
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
        if (source == null)
         throw new ArgumentNullException("source");
        var medianValue = source.OrderBy(n => n).ToArray();
        if (medianValue.Length == 0)
            throw new InvalidOperationException();
        if (medianValue.Length % 2 == 0)
            return (medianValue[medianValue.Length / 2 - 1] + medianValue[medianValue.Length / 2]) / 2.0;
        return medianValue[medianValue.Length / 2];       
      } 
/* 
      static int[] Mode(int[] source)
      {

       return  ;
      } */

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
