/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number < 10000 || number > 99999) {
Console.WriteLine("Число не является пятизначным!");
 return; }
bool isPalindrome = true;
string numberStr = number.ToString();
for (int i = 0; i < numberStr.Length / 2; i++)
 {
 if (numberStr[i] != numberStr[numberStr.Length - i - 1])
 {
 isPalindrome = false;
 break;}
}
if (isPalindrome) {
Console.WriteLine("Число является палиндромом!");
}
else
{
Console.WriteLine("Число не является палиндромом!");
}