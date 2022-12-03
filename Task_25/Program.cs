Console.WriteLine($"\n Задачка №25. Возведене числа A в натуральную степень B");

int Exponent(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponent = Exponent(numberA, numberB);
  Console.WriteLine("Ответ: " + exponent);