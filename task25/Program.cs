while (true)
{

    int ApowB(int A, int B)
    {
        int result = 1;
        for (int i = 0; i < B; i++)
        {
            result *= A;
        }
        return result;
    }
    Console.WriteLine("Введите число А");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int B = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Результат: {ApowB(A, B)}");

    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}