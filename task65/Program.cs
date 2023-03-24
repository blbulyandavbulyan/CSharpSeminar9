﻿//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5-> "1, 2, 3, 4, 5"
//M = 4; N = 8-> "4, 5, 6, 7, 8"
void PrintNumbersFromMToN(int M,  int N)
{
    if(M == N)
    {
        Console.WriteLine(N);
    }
    else
    {
        Console.Write($"{M}, ");
        PrintNumbersFromMToN(M + 1, N);
    }
}
PrintNumbersFromMToN(4, 9);
PrintNumbersFromMToN(10, 20);