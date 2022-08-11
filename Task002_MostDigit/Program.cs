int MostVal()
{
    int randomval=new Random().Next(10,100);
    Console.WriteLine($"Generated value is:{randomval}");

    if((randomval/10)>(randomval%10)) 
    {
        return randomval/10;
    }
    else
    {
        return randomval%10;
    }
    return 0;
}



int A = MostVal();

Console.WriteLine($"Largest digit is {A}");
