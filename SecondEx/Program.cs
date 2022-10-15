int num1 = new Random().Next(1, 10);
int num2 = new Random().Next(1, 10);
int num3 = new Random().Next(1, 10);

Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.Write("Максимальное часло: ");
Console.WriteLine(max);
