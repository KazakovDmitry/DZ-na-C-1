/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число: ");
string numbersA = Console.ReadLine();
int a = Convert.ToInt32(numbersA);

Console.WriteLine("Чётные числа от 1 до " + a);
for (int i = 2; i <= a; i = i + 2)
{
    Console.Write(i + " ");
}