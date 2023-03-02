// Задача №3   
// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.



// Console.WriteLine("Введите число: ");
// var day = Convert.ToInt32(Console.ReadLine());
// if (day > 0 && day < 8)
// {
//   string[] dayWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
//       Console.WriteLine(dayWeek[day - 1]);
// }
// else
// {
//  Console.WriteLine("Вы ввели не день недели!");
// }






Console.WriteLine("Введите номер дня недели: ");
string? LineDay = Console.ReadLine();
if (LineDay != null)
 {
     int day = int.Parse(LineDay);

//    string[] dayWeek = new String [7];
//    dayWeek[0] = "Понедельник";
//    dayWeek[1] = "Вторник";
//    dayWeek[2] = "Среда";
//    dayWeek[3] = "Четверг";
//    dayWeek[4] = "Пятница";
//    dayWeek[5] = "Суббота";
//    dayWeek[6] = "Воскресенье";
//    Console.WriteLine(dayWeek[day - 1]);


string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));

Console.WriteLine(outDayOfWeek);
}