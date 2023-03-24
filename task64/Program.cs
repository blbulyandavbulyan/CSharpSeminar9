//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void PrintNaturalNumbersFromNToOne(int N)
{
    if (N != 1)
    {
        Console.Write($"{N}, ");
        PrintNaturalNumbersFromNToOne(N - 1);
    }
    else
    {
        Console.WriteLine(1);
    }
}
PrintNaturalNumbersFromNToOne(10);