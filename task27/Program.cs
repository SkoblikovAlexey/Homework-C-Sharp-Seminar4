// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

while (true)
{
    int CalcLength(int num) // функция вычисляет количество знаков в числе
    {
        int length = 0;
        do
        {
            num = num / 10;
            length++;
        }
        while (num >= 1);
        return length;
    }

    int CalcSum(int num, int func) // функция кладет в сумму число от остатка деления на 10 и уменьшает в 10 раз само число на каждой итерации
    {
        int summ = 0;
        for (int i = 0; i < func; i++)
        {
            summ = summ + num % 10;
            num = num / 10;
        }
        return summ;
    }

    Console.WriteLine("Введите число.");

    int number = Convert.ToInt32(Console.ReadLine());

    int result = CalcSum(number, CalcLength(number));

    Console.WriteLine($"Сумма знаков в числе равна {result}.");

    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}