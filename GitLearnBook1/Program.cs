uint startNumber=0U;
uint countChair=0U;

for(var start = 1000000U; start>0; start--){
 var n=start;
 var i=1U;

 while(n!=1){
    if(n%2==0){
        n/=2;
    }else{
        n=3*n+1;
    }
    i++;
 }
    if(i<countChair){
        continue;
    }
    startNumber=start;
    countChair=i;
}
var answer=startNumber;

System.Console.WriteLine($"Wynik dla warunków w zadaniu to: {answer}");
//test rozwiazywania konfliktów

System.Console.WriteLine("konflikt");
//tu tez

//test rozwiazywania konfliktów

System.Console.WriteLine("konflikt");
//tu tez