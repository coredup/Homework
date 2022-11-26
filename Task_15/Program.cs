// 15 задачка 
Console.WriteLine("Задачка номер 15");

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("( выходной 6 - суббота , 7 - воскресенье) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это не день недели (Дни 1-понедельник,2-вторник,3-среда,4-четверг,5-пятница,6-суббота,7-воскресенье");
  }
  else Console.WriteLine("(выходной 6 - суббота и 7 - воскресенье) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);