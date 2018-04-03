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
        return null;
      }
      static int Maximum(int[] source)
      {
        int maxValue = source.Max();
        return maxValue;
      }

      

    }
}
