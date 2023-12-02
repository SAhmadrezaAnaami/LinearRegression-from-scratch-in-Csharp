using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] x = { 1, 2, 3, 4 ,5,6,7,8,9 };
            double[] y = { 3,5,7,9,11,13,15,17,19 };
            LinearRegression lm = new LinearRegression(5000, 0.01);
            lm.fit(x, y);
            Console.WriteLine(lm.predict(10 , false));
            lm.printWeights();
            Console.ReadLine();
        }
    }
}
