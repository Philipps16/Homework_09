int SumNumbers(int start, int end)
{
if (end == start)
{
return end;
}
end = end + SumNumbers (start, end - 1); 
return end;

}





Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine(SumNumbers(n, m));

