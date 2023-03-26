//  Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Укажите число > ");
string value;
value = Console.ReadLine();
int number = Convert.ToInt32(value);
int i = 1; // начало промежутка
while (i <= number)
{
    if (i % 2 == 0)
        Console.Write(i + " ");
    i++;
}