
// Задача №7
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// Например:
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.WriteLine("Введите число");
// // Считываем данные с консоли

// string? inputLineN = Console.ReadLine();

// // // Проверяем чтобы данные не были пустыми 

// if(inputLineN != null)

//  {
//      // Парсим введенное число
      
//  int inputNumber = int.Parse(inputLineN);

// int res = inputLineN%10;

// Console.WriteLine("Последняя цифра" + res);

//  }

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
    Console.WriteLine("Последняя цифра числа: "+number%10);
}
else
{
    Console.WriteLine("Введено не то число ");
}