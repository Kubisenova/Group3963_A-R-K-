// Задача №16
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого.
// Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


// Первый способ

void squareTest(int num1, int num2)
{
    if (num1 == Math.Pow(num2, 2))
    {
        Console.WriteLine($"Число {num1} является квадратом числа {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
    }
}

Console.WriteLine(" Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

squareTest(num1, num2);
squareTest(num2, num1);


// Второй способ 


// void Squared(int num1, int num2)
// {
//     if(num2 == num1*num1)
//     {
//         Console.WriteLine($"{num2} - квадрат {num1}");
//     }
//     else
//     {
//         Console.WriteLine($"{num1} - квадрат {num2}");
//     }

// }

// Console.WriteLine(" Введите первое число ");
// int num1 = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine(" Введите второе число ");
// int num2 = int.Parse(Console.ReadLine()??"0");

// Squared(num1, num2);
