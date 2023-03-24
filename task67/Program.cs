//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
int GetSumOfDigitsInNumberRecursive(int N)
{
    if (N < 10) return N;
    else return N % 10 + GetSumOfDigitsInNumberRecursive(N / 10);
}
Console.WriteLine(GetSumOfDigitsInNumberRecursive(453));
Console.WriteLine(GetSumOfDigitsInNumberRecursive(45));
Console.WriteLine(GetSumOfDigitsInNumberRecursive(121));