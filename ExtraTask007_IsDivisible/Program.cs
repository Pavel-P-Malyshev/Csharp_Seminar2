/*
4.1. Напишите программу, которая генерирует 
несколько случайных чисел, и в цикле проверяет, 
кратны ли эти числа предварительно введенному 
числу, при кратности - цикл прерывается.
Введенное число 2
13 -> нет 
15 -> нет 
12 -> да
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

void IsDivisible(int value)
{
    int[] randoms= new int[10];
    int position=0;
    while(position<10) 
    {
        randoms[position]=new Random().Next(1,100);
         Console.WriteLine($"генерируем {position+1} случайное число:{randoms[position]}");
         position++;
    }
    
    position=0;
    while(position<10)
    {
        if(randoms[position]%value==0)
        {
            Console.WriteLine($"текущее число {randoms[position]} кратно вашему числу {value}, выходим из цикла!");
            break;
            
        }

        Console.WriteLine($"текущее число {randoms[position]} НЕ кратно вашему числу {value}, продолжаем!");

        position++;
    }

  

}

int num=Prompt("Введите ваше число:");
IsDivisible(num);

