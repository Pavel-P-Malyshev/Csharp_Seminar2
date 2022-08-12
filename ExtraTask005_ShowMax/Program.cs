/*
2.1. Напишите программу, которая выводит 
случайное число из отрезка [10, 9999] и 
показывает наибольшую цифру числа.
7812 -> 8 
1213-> 3 
845 -> 8
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int ShowMax()
{
    int randomval=new Random().Next(10,100000);
    Console.WriteLine($"Generated value is:{randomval}");
    
    List<int> Digits=new List<int>();
    List<int> Quots=new List<int>();
    Digits.Add(randomval%10);
    Quots.Add(randomval/10);
    int index=1;
    int max=Digits[0];

    while(Quots[index-1]>0)
    {
        Quots.Add(Quots[index-1]/10);
        Digits.Add(Quots[index-1]%10);
       
        if(Digits[index]>max) {max=Digits[index];}
       
        index++;
    }

    //второй вариант цикла - просто делим на 10 в цикле пока частное не будет меньше нуля
    //и сразу записываем в макс
    /*
     int max=0;
     while(randomval>0)
     {
        int a=randomval%10;
        if (max<a){max=a;}
        randomval=randomval/10
     }

    */




    return max;
}

int result=ShowMax();
Console.WriteLine($"maximum digit of random number is:{result}");


