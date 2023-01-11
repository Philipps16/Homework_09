string PrintNumbers(int start, int end)
{
if (start == end)
{
return start.ToString();
}
return (end.ToString() + ' ' + PrintNumbers(start, end - 1));
}





Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(n, m));

