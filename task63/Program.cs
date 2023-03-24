//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
//На данный момент понятия не имею как это сделать
void RecursiverPrintNaturalNumnbers(int N)
{
    Console.Write(N);
    if (N == 1)return;
    else
    {
        RecursiverPrintNaturalNumnbers(N);

    }
}