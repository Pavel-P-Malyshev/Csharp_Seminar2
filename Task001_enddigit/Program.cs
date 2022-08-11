
int EndDigit(int value)
{
        
    return value%10;
}
Console.WriteLine("Enter you 3 digits number:");
int A = int.Parse(Console.ReadLine()); //преобразование строки в целове число
while(A>999||A<100)
    { 
        Console.WriteLine("Your number has not 3 dogits, enter another:");
        A = int.Parse(Console.ReadLine());
    }
Console.WriteLine($"Last digit of your number is: {EndDigit(A)}");
