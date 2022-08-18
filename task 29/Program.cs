// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

while (true)
{
int[] CreateArray(int N)
{
    int[] arr = new int[N];
    Console.WriteLine($"Введите {N} элементов массива");
    for (int i = 0; i < N; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[length - 1] + "]");
}
Console.WriteLine("Введите число, равное количеству элементов в массиве");
int N = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateArray(N));

Console.WriteLine();

Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}
