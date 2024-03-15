
var temperraturedaily=new DailyTemperature(2.0,15.0);
System.Console.WriteLine($"Temeratura wynosi{temperraturedaily.HightTemp} oraz {temperraturedaily.LowTemp}");
var FullName=new FullName{
FirstName="Jacek",
LastName="kaszanka"
};
var result=FullName.FirstName+""+FullName.LastName;
System.Console.WriteLine(result);
public record FullName{
    public string FirstName {get; set;}
    public string LastName {get; set;}
}
public readonly record struct DailyTemperature(double HightTemp, double LowTemp );

