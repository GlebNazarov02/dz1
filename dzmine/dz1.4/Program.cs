Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
var i = 0;
if (n < 2)
{
Console.Write("0");
}
else if (n % 2 == 0)
{while (i < n )
    {
    i += 2;
    Console.Write($"{i}");
    Console.Write(" ");
    }
}
else 
{while (i < (n - 1) )
    {
    i += 2;
    Console.Write($"{i}");
    Console.Write(" ");
    }
}