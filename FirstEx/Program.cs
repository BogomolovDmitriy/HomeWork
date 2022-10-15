int num1 = new Random().Next(1, 10);
int num2 = new Random().Next(1, 10);

Console.WriteLine(num1);
Console.WriteLine(num2);

if (num1 > num2)
{
    Console.Write("Максимальное часло: ");
    Console.WriteLine(num1);
}
else
{
    Console.Write("Максимальное часло: ");
    Console.WriteLine(num2);
}