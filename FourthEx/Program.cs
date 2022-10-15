int num = new Random().Next(1, 10);
Console.Write("Выбрано число: ");
Console.WriteLine(num);
int count = 1;

while (count <= num)
{
    if (num == 1)
    {
        Console.WriteLine("До этого числа нет четных чисел.");
    }
    
    if ((count % 2) == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}