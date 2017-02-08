using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoViisi2
{
    public class ArrayCalcs
    {
        static public double Sum(double[] d)
        {

            double sum = 0;
            foreach (double doub in d)
            {
                sum += doub;
            }
            return sum;
        }
        static public double Average(double[] d)
        {
            return Sum(d) / d.Length;
        }
        static public double Min(double[] d)
        {
            return d.Min();
        }
        static public double Max(double[] d)
        {
            return d.Max();
        }
    }
}
