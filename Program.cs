using System;

// ----------------------------------------------------------------------------------------
// Задача 64: Задайте значение N. Напишите программу,
//              которая выведет все натуральные числа в промежутке от N до 1.
//            Выполнить с помощью рекурсии.

void NaturalNumbersCountdown(int N)
{   // Введите свое решение ниже
    if (N > 1) {
        Console.Write($"{N}, ");
        NaturalNumbersCountdown(N - 1);
    } else {
        Console.WriteLine($"{N}\"");
    }
}

int num = 0;
Console.Write("Please, enter a natural number: ");
while (!int.TryParse(Console.ReadLine(), out num) || num < 1) {
    Console.Write("This is not a natural number. Please, enter a natural number: ");
}

Console.Write($"Natural numbers in backward order from {num} to 1: \"");
NaturalNumbersCountdown(num);
Console.WriteLine("-----------------------------------------------");

// ----------------------------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу,
//              которая найдёт сумму натуральных элементов в промежутке от M до N.

void NaturalNumbersSumm(int N, int M)
{   // Введите свое решение ниже
    int sum = 0;
    for (int i = N; i <= M; i++) {
        sum += i;
    }
    Console.WriteLine($"{sum}");
}

int M = 0;
Console.Write("Please, enter the first natural number: ");
while (!int.TryParse(Console.ReadLine(), out M) || M < 1) {
    Console.Write("This is not a natural number. Please, enter a natural number: ");
}

int N = 0;
Console.Write("Please, enter the second natural number: ");
while (!int.TryParse(Console.ReadLine(), out N) || N < 1 || N <= M) {
    Console.Write("This is not a natural number or the second number" +
                  " is not greater than the first. Please, enter a natural number: ");
}

Console.Write($"The summ of numbers between {M} and {N}: ");
NaturalNumbersSumm(M, N);
Console.WriteLine("-----------------------------------------------");

// ----------------------------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//              Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int m = 0;
Console.Write("Please, enter the first natural number: ");
while (!int.TryParse(Console.ReadLine(), out m) || m < 0) {
    Console.Write("This is not a natural number. Please, enter a natural number: ");
}

int n = 0;
Console.Write("Please, enter the second natural number: ");
while (!int.TryParse(Console.ReadLine(), out n) || n < 0) {
    Console.Write("This is not a natural number or the second number" +
                  " is not greater than the first. Please, enter a natural number: ");
}

Console.WriteLine($"Ackermann's function of {m} and {n}: {Ackermann(m, n)}");