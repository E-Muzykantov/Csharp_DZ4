// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();

Console.Write("Введите число для возведения в степень: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine());


bool ChekB(int b)
{
    if (b < 0)
    {
        Console.WriteLine("Степень не должна быть отрицательной");
        return false;
    }
    return true;
}

Double GetExponentiation(int a, int b)
{
    Double result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }

    return result;
}

if (ChekB(b)) Console.WriteLine($"Число {a} в степени {b} = {GetExponentiation(a, b)}");