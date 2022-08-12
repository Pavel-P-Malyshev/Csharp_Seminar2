/*
3.1. Напишите программу, которая будет принимать 
на вход пять чисел и выводить сумму и среднее 
арифметическое этих чисел.
2, 5, 6, 8, 1 -> сумма 22, среднее 4,4
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


double SumAvg(int[] numbers, bool retval)
{
    int count=numbers.Length;
    int position=0;
    double sum=0;
    double avg=0;
    while(position<count) 
    {
        sum+=numbers[position];
        position++;
    }
    avg=sum/count;
    if(retval) {return sum;}
    else {return avg;}

    return 0;
}

int[] values= new int [5]; 

for (int i=0;i<5;i++)
{
   values[i]=Prompt($" Введите число {i+1}:");
}

Console.WriteLine($" сумма чисел = {SumAvg(values,true)}");
Console.WriteLine($" среднее чисел = {SumAvg(values,false)}");
