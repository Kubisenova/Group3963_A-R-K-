// Задача №11
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98 

int num = new Random().Next(100, 1000);
Console.WriteLine(" Рандомное число " + num);
// Другой вариант решение этой задачи Console.WriteLine((num / 100) * 10 + (num % 10));
//  Чтобы не писать эти четыре строчки 
Console.WriteLine(num);
int LastDigit = num % 10;
int firstDigit = num / 100;
num = firstDigit * 10 + LastDigit;
Console.WriteLine(" Результат работы " + num);
