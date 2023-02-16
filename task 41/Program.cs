// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Введи число М(количество чисел): ");
int m =int.Parse(Console.ReadLine()!)!;
int[] massNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massNumbers[i] =int.Parse(Console.ReadLine()!)!;
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($" {Comparison(massNumbers)} из них больше 0");
