// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<int> list=new List<int>{1,2,3,4};
foreach(var x in list){
System.Console.WriteLine(x);
}

Dictionary<int,string> dic=new Dictionary<int, string>();
dic.Add(1,"ala");
dic.Add(2,"kot");
dic.Add(3,"test");

foreach(var i in dic){
    System.Console.WriteLine(i);
}