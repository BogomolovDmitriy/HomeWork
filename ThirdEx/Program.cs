int num = new Random().Next(1, 100);

if ((num % 2) == 0)
{
    Console.Write(num);
    Console.WriteLine(" - четное число.");
}
else
{
    Console.Write(num);
    Console.WriteLine(" - нечетное число.");
}