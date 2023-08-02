// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());            // Красивее было бы через WHILE, но я художник, я так вижу) Тем более, что по условиям задачи мы ограничены лишь тремя числами)

if (num1 > num2 && num1 > num3)
{
    Console.Write($"{num1} - самое большое число");
}
else
{
    if (num2 > num3)
    {
        Console.Write($"{num2} - самое большое число");
    }
    else
    {
        Console.Write($"{num3} - самое большое число");
    }
}