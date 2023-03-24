//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
//как решить без параметра по умолчанию и при этом чтобы вывод был через запятую как в примере представления не имею
void RecursiverPrintNaturalNumnbers(int N, int notTouchThisValue = 0)
{
    if (notTouchThisValue == 0) notTouchThisValue = N;
    if (notTouchThisValue == 1)
    {
        Console.Write("1, ");
    }
    else { 
        RecursiverPrintNaturalNumnbers(N, notTouchThisValue - 1);
        Console.Write(N != notTouchThisValue ? $"{notTouchThisValue}, " : $"{notTouchThisValue}");
    }
}
RecursiverPrintNaturalNumnbers(10);