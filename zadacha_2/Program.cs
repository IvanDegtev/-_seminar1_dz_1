//  Задача 2: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Укажите число a  ");
string value;
value = Console.ReadLine();
int numberA = Convert.ToInt32(value);

Console.Write("Укажите второе число b  ");
value = Console.ReadLine();
int numberB = Convert.ToInt32(value);

Console.Write("Укажите второе число c  ");
value = Console.ReadLine();
int numberC = Convert.ToInt32(value);

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);