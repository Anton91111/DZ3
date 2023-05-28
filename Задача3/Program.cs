/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Concole.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до {0}:", n);
for (int i = 1; i <= n; i++)
{
int cube = i * i * i;
Console.WriteLine(cube);
if (i != n)
{
Console.WriteLine(", ");
}
}

