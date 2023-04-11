Console.WriteLine("Введите число M");
int M =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N =int.Parse(Console.ReadLine());
int temp;

if (M>N) 
{
    temp = N;
    N = M;
    M = temp;
}
temp = M;

int Sum()
{
if(M>=N)
{
    return temp;
}
M++;
return M + Sum();
}

Console.WriteLine($"Сумма чисел равна {Sum()}");