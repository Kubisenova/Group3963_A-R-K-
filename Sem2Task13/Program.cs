//Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// *Сделать вариант для числа длиной до 10 цифр не используя char или string


// // Первое решение
// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {
//     int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }
//         result = (a / c) % 10;
//     }
//     return result;
// }



// Второе решение
Console.WriteLine("Введите число:  ");
string? numA = Console.ReadLine();

if (numA.Length >= 3)
{
    char[] array = numA.ToCharArray();
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет ");
}