/* Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Определим какое из трёх чисел больше");
Console.WriteLine("Введите первое число: ");
string numbersA = Console.ReadLine();
int a = Convert.ToInt32(numbersA);
Console.WriteLine("Введите второе число: ");
string numbersB = Console.ReadLine();
int b = Convert.ToInt32(numbersB);
Console.WriteLine("Введите третье число: ");
string numbersC = Console.ReadLine();
int c = Convert.ToInt32(numbersC);

int max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.WriteLine("max = " + max);