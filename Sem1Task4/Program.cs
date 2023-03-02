// Задача №4 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел. 
// 2, 3, 7 -> 7 44 5 78 -> 78 22 3 9 -> 22

Console.WriteLine("Введите первое число; ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число; ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число; ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine("Первое число больше");
    }
    else
    {
        Console.WriteLine("Второе число больше");
    }
}
else
{
    if (numberB > numberC)
    {
        Console.WriteLine("Второе число больше");
    }
    else
    {
        Console.WriteLine("Третье число больше");
    }
}