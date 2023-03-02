// Задача 0
// Напишите программу, которая на вход принимает число и выдаёт его квадрат
// (число умноженое на само себя)

// Console.WriteLine("Введите число: ");

// // Считываем данные консоли

// String? inputNum = Console.ReadLine();

// // Проверяем, чтобы данные были не пустые
// if (inputNum != null)
// {
//     //парсим введенное число
//     int number = int.Parse(inputNum);

//     //Находим квадрат числа
//     //int outNum = number*number;
//     int outNum = (int)Math.Pow(number,2);

//     //Выводим данные в консоль 
//     Console.WriteLine("Квадрат числа: " +outNum);

//    //Console.WriteLine("Квадрат числа: " +Math.Pow(int.Parse(inputNum),2));
// }

Console.WriteLine("Введите число ");
string? inputNum = Console.ReadLine();


if (inputNum != null)
{
    int number = int.Parse(inputNum);

    int outNum = number * number;
    Console.WriteLine("Квадрат числа ");

    Console.WriteLine(outNum);

}
