Console.WriteLine("Введите 1 число");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int second = int.Parse(Console.ReadLine());
if (first > second) 
{
    Console.Write("Большее число - ");
    Console.Write($"{first}");
}
else if  (first < second)
{
    Console.Write("Большее число - ");
    Console.Write($"{second}");
}
else{
    Console.Write("Равенство ");
    Console.Write($"{second}");
}