// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

  int SumNumber(int number)
    {    
    int counter = (number / 10);
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

int SumResult = SumNumber(number);
Console.WriteLine(SumResult);