Console.Write("Введите количество монеток: ");
int n = int.Parse(Console.ReadLine());
int a = 0;
int b = 0;
for (int i = 0; i < n; i++)
{
 Console.Write($"Введите сторону монетки {i + 1} (1 - решка, 0 - орел): ");
int c = int.Parse(Console.ReadLine());
if (c == 1)
{
a++; }
else
{
b++;
}}

int x = Math.Min(a, b);
Console.WriteLine($"Минимальное количество переворотов монеток: {x}");
    