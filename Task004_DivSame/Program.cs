/*
4. Напишите программу, которая принимает на вход 
число и проверяет, кратно ли оно одновременно 7 и 
23.
14 -> нет 
46 -> нет 
161 -> да

*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

bool DivSame(int input)
{
    if((input%7==0)&&(input%23==0)) {return true;}
    return false;

}

int num1=Prompt("Введите число:");

if(DivSame(num1)) 
{
    Console.WriteLine ($"Ваше число {num1} кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine ($"Ваше число {num1} НЕ кратно 7 и 23 одновременно");
}

