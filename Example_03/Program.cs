int Function (int number, int argument)
{
    if (number == 0)
    return argument + 1;
    else
        if (number != 0 && argument == 0)
        return (Function (number - 1, 1));
        else
            return (Function (number - 1, Function (number, argument - 1)));

    return number;    
}








Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
if ( n <= 0)
{
    Console.Write ("Введите НЕОТРИЦАТЕЛЬНОЕ число: ");
    n = int.Parse(Console.ReadLine());
}
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
if ( m <= 0)
{
    Console.Write ("Введите НЕОТРИЦАТЕЛЬНОЕ число: ");
    m = int.Parse(Console.ReadLine());
}

Console.WriteLine($"{n}, {m} -> A ({n},{m}) = {Function(n, m)}");
