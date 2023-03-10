// Задача №10 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1 

// Первое решение
// Console.WriteLine(" Введите трехзначное число ");
// int numA = int.Parse(Console.ReadLine()?? "0");
// int numB = (numA/10)%10;
// Console.WriteLine(numB);



// // Второе решение
// // Второе решение - работает.

// Console.WriteLine("Введите трехзначное число: ");
// // число переводим в строку и задаём ей длину

// int size = Convert.ToInt32(Console.ReadLine());

// int number = size.ToString().Length;

// if (number < 3 || number > 3)
// {
// Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
// Console.WriteLine(size);
// int numbC = size;

// numbC = (numbC / 10) % 10;
// Console.WriteLine(numbC);
// }


// Второе решение

Console.WriteLine("Введите трехзначное число: ");
// число переводим в строку и задаём ей длину

int size = Convert.ToInt32(Console.ReadLine());

int number = size.ToString().Length;

if (number < 3 || number > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(size);

    int numbC = size;

    numbC = (numbC / 10) % 10;
    Console.WriteLine(numbC);
}