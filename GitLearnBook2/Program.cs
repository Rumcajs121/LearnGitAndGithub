Function function = new Function();
var x1 = function.Result(4);
var x2 = function.Result(4.0M);
var x3 = function.Result(4.0D);

System.Console.WriteLine($"Result is:{x1} type: {x1.GetType()},{x2} type: {x2.GetType()},{x3} type: {x3.GetType()}");
public class Function
{
    public int Result(int x)
    {
        return (int)Math.Sqrt((double)(x * 35));
    }

    public double Result(double x)
    {
        return Math.Sqrt(x * 35);
    }
    public decimal Result(decimal x)
    {
        return (decimal)Math.Sqrt((double)(x * 35));
    }
}
