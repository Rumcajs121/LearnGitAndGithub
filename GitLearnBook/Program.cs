using System;
var random= new Random();
int randomNumber=random.Next(1,1001);
System.Console.WriteLine($"Wylosowana liczba to: {randomNumber}");
NumberConverter convert=new NumberConverter();
string result=convert.GetFourDigitNumber(randomNumber);
System.Console.WriteLine($"Zapis słowny liczby: {result}");

string skipWhiteSpace=result.Replace(" ","");
int countString= skipWhiteSpace.ToCharArray().Count();

System.Console.WriteLine($"Długość ciągu znaków:{countString}");




public class NumberConverter{
public string[] One = { "","one", "two", "three", "four", "five", "six", "eight", "nine" };
public string[] Ten = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
public string[] Tenth = { "", "","twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
public string GetOneDigitNumber(int number)
{
    return this.One[number];
}
public string GetTwoDigitNumber(int number){
    int second=0;
   if (number < 10)
   {
      return this.GetOneDigitNumber(number);
   }
   else if (number >= 10 && number < 20)
   {
    second = Convert.ToInt32(number.ToString().Substring(1, 1));
      return this.Ten[second];
   }
   int first = Convert.ToInt32(number.ToString().Substring(0, 1));
   second = Convert.ToInt32(number.ToString().Substring(1, 1));
    if(second != 0){
        return Tenth[first]+"-"+One[second];
    }
    return Tenth[first]+One[second];
    }
public string GetThreeDigitNumber(int number){
   int first = Convert.ToInt32(number.ToString().Substring(0, 1));
   string secondhalf = "";
   if (number.ToString().Length == 3)
   {
      secondhalf = this.GetTwoDigitNumber(Convert.ToInt32(number.ToString().Substring(1, 2)));
      
      secondhalf = string.IsNullOrEmpty(secondhalf) == false ? "and " + secondhalf : string.Empty;
      return $"{this.One[first]} hundred {secondhalf}";
   }
   return GetTwoDigitNumber(number);
}
public string GetFourDigitNumber(int number){
    if (number.ToString().Length == 4)
   {
    return " one thousand";
   }
   return this.GetThreeDigitNumber(number);
}
}

//test first pull request
