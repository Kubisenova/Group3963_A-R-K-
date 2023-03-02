// //Задача 1
// //Напишите программу, которая на вход принимает два числа
// //и проверяет является ли первое число квадратом второго.

// Console.WriteLine("Введите число №1: ");
// string? numLine1 = Console.ReadLine();
// //Ввод числа №2
// Console.WriteLine("Введите число №2: ");
// string? numLine2 = Console.ReadLine();

// if (numLine1 != null && numLine2 != null)
// {
//     //Convert to int
//     int num1 = int.Parse(numLine1);
//     int num2 = int.Parse(numLine2);

//     if (num2 * num2 == num1)
//     {
//         Console.WriteLine("Да, является!");
//     }    
//     else
//     {
//         Console.WriteLine("Нет, не является!");
//     }
// }

Console.WriteLine("введите первое число: ");
string? inputNumber1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inputNumber2 = Console.ReadLine();

if (inputNumber1 != null && inputNumber2 != null)
{
    int number1 = int.Parse(inputNumber1);
    int number2 = int.Parse(inputNumber2);

    if (number2 * number2 == number1)
    {
        Console.WriteLine("Да, является!");
    }

    else
    {
        Console.WriteLine("Нет, не является!");
    }
}