using System;
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
    }
}
