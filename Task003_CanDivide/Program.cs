/*
3. Напишите программу, которая будет принимать на 
вход два числа и выводить, является ли второе число 
кратным первому. Если число 2 не кратно числу 1, то 
программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int num1=Prompt("Введите число1:");
int num2=Prompt("Введите число2:");
if(num1%num2>0) {
    Console.WriteLine ($"Остаток от деления {num1}/{num2} равен:{num1%num2}");
}