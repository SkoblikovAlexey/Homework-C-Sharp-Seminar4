// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

double number = 152;

double CalcCount(double num)
{  // функция вычисляет количество знаков в числе
    double count = 0;
    do
    {
        num = num / 10;
        count++;
    }
    while (num >= 1);
    return count;
}

double CalcSum(double num, double func)
{
    double summ = 0;
    for (double i = func - 1; i >= 0 + 1; i--)
    {
          summ = summ + Math.Round(num / Math.Pow(10, i));
          num = num - num/Math.Pow(10, i);   
      Console.WriteLine(summ);
      Console.WriteLine();
      Console.WriteLine(summ);
    }
    return summ;
}
double result = CalcSum(number, CalcCount(number));
Console.WriteLine(result);
// do {
//     number = number / 10;
//     count++;
// }
// while (number >= 1);
// Console.WriteLine(count);