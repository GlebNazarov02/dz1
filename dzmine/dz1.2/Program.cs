Console.WriteLine("Введите 1 число");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int third = int.Parse(Console.ReadLine());
int max = first;
if (max < second )
{
    max = second;  
}
if  (max < third)
{
    max = third;    
}
Console.Write("Максимальное число - ");
Console.Write($"{max}");
