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

      

    }
}
