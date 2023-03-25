// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2

// 5
// 1, -7, 567, 89, 223-> 3



Console.WriteLine("Введите количество чисел");
int M = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[M];
FillArray(array, M);
PrintArray(array);
Console.WriteLine($"Введено {PosElemQuantity(array)} чисел больше 0");


void FillArray(int[] array, int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32 (Console.ReadLine());
        array[i] = num;
    }
}


void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}


int PosElemQuantity(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0) count++;
    }
return count;
}