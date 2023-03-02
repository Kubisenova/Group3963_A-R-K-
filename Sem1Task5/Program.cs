// Задача №5
// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"



//  1 вариант решения задачи 

Console.WriteLine("Введите число");
var day = Convert.ToInt32(Console.ReadLine());
var negDay = -day;
for (; negDay <= day; negDay++)
{
    Console.Write(negDay+ "\t");
} 



// 2 вариант решения задачи


// Console.WriteLine("Введите число");
// Считываем данные с консоли
// string? inputLine = Console.ReadLine();

// // Проверяем чтобы данные не были пустыми 

// if(inputLine!=null)

// {
//     // Парсим введенное число
//     int inputNumber = int.Parse(inputLine);

//     // Вводим специальную переменную с отрицательным значением
//     int startNumber = inputNumber*(-1);

//     // Выходное значение 
//     // Emty - это для накомпления 

//     string outline = string.Empty;

//     while(startNumber<inputNumber)
//     {
//         outline = outline + inputNumber  +  ",  ";
//         startNumber++;
//         // startNumber=startNumber+1;

//     }

//     outline = outline + inputNumber;

//     // Выводим данные в консоль 
//     Console.WriteLine(outline);
    
// }