ArithmeticMean mean = new ArithmeticMean();
//Example 1
var meanResult = mean.MeanScores(4, 5, 7, 8, 9, 10);
//Example 2
List<double> list = new List<double>() { 1.3, 2.5, 3.2, 4.1, 5.0 };
double[] arr = new double[] { 1, 2, 34, 56, 2 };

var meanResult1 = mean.MeanScores(arr, list);

System.Console.WriteLine($"Result: Example 1 int parameters: {meanResult}, Example 2 object parameters {meanResult1}");

public class ArithmeticMean
{
    public double MeanScores(params int[] args)
    {
        int count = args.Length;
        var SumResult = args.Sum();
        System.Console.WriteLine(count);
        return SumResult / count;
    }
    public double MeanScores(params object[] args)
    {
        List<double> combinedList = new List<double>();
        foreach (var arg in args)
        {
            if (arg is double)
            {
                combinedList.Add((double)arg);
            }
            else if (arg is IEnumerable<double>)
            {
                combinedList.AddRange((IEnumerable<double>)arg);
            }
        }
        int count = combinedList.Count;
        double sumResult = combinedList.Sum();
        System.Console.WriteLine(count);
        return sumResult / count;
    }
}

