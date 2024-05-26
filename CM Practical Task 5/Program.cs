using System;
using System.Linq;

class Program
{
    static void Main()
    {
       // double[,] datapoints = { { 3, 6 }, { 0, 3 }, { 2, 1 } };
             //  double[,] datapoints = { {{3, 6}, {3, 7}} };

                double[,] datapoints = { {-1, 1.25}, {2, 3.5} };

        Func<double, double> f = PolyInterpolate(datapoints);


        Console.WriteLine("f(-1) = "+f(-1));
        //Console.WriteLine("f(0) = "+ f(0));     

        Console.WriteLine("f(1) = "+f(1));

        //Console.WriteLine("f(2) = " + f(2));      
        //Console.WriteLine("f(2.75) = " + f(2.75));   
        //Console.WriteLine("f(3) = " + f(3));

    }

    static Func<double, double> PolyInterpolate(double[,] datapoints)
    {
        ValidateDataPoints(datapoints);
        double[] coefficients = CalculateCoefficients(datapoints);

        return x => {
            if (!(datapoints.Cast<double>().Where((value, index) => index % datapoints.GetLength(1) == 0).Min() <= x   //select only ones falling in the range of x values in datapoints
                && x <= datapoints.Cast<double>().Where((value, index) => index % datapoints.GetLength(1) == 0).Max())) {
                
                throw new Exception("out of bounds");
            }

            double result = coefficients[datapoints.GetLength(0) - 1];
            for (int i = datapoints.GetLength(0) - 2; i >= 0; i--)
            {
                
                result = result * (x - datapoints[i, 0]) + coefficients[i];
            
            }

            return result;
        
        };
    }

    static void ValidateDataPoints(double[,] datapoints)
    {
        int numRows = datapoints.GetLength(0);


        if (numRows < 2)
        {
            
            throw new Exception("at least two data points are required");
        
        }

        for (int i = 0; i < numRows - 1; i++)
        {

            for (int j = i + 1; j < numRows; j++)
            {
               
                if (datapoints[i, 0] == datapoints[j, 0])
                {
                    
                    throw new Exception("duplicate x values");
                
                }
            }
        }
    }

    static double[] CalculateCoefficients(double[,] dataPoints)
    {
        int n = dataPoints.GetLength(0) - 1;

        double[] coefficients = new double[n + 1];
        double[] yValues = new double[n + 1];

        for (int i = 0; i <= n; i++)
        {
            
           coefficients[i] = dataPoints[i, 1];
           
            yValues[i] = dataPoints[i, 1];
        }

        for (int k = 1; k <= n; k++)
        {
            for (int j = n; j >= k; j--)
            {
                coefficients[j] = (coefficients[j] - coefficients[j - 1]) / (dataPoints[j, 0] - dataPoints[j - k, 0]);
            }
        }

        return coefficients;
    }
}
