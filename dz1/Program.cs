// Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от m до N . Выполнить с помощью рекурсии.

// M, N = 5, 8 -> "6, 8"
// M, N = 2, 4 -> "2, 4"

// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Так что задайте числа m и n (через , или пробел):");
char[] separators = { ' ', ',', ';' };
int[] mn = Array.ConvertAll(Console.ReadLine()!.Split(separators), int.Parse);

if (mn[0] > mn[1])
    (mn[0], mn[1]) = (mn[1], mn[0]);
System.Console.Write("64: ");
Task64(mn[0], mn[1]);
System.Console.WriteLine("\n66: Сумма равна " + Task66(mn[0], mn[1]));

void Task64(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0 & m > 0) System.Console.Write(m + " ");
    Task64(m + 1, n);
}

int Task66(int sum, int n)
{
    if (sum >= n) return sum;
    if (sum > 0)
        sum += Task66(sum + 1, n);
    return sum;
}
