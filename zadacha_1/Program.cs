//  Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

Console.Write("Укажите число a  ");
string value;
value = Console.ReadLine();
int numberA = Convert.ToInt32(value);

Console.Write("Укажите второе число b  ");
value = Console.ReadLine();
int numberB = Convert.ToInt32(value);
int max;
int min;
if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
