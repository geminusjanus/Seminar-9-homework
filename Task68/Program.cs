// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите целое число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число N");
int numN = Convert.ToInt32(Console.ReadLine());

int Ackermann(int n, int m)
{
    if (n == 0) return m + 1;
    if ((n != 0) && (m == 0)) return Ackermann(n - 1, 1);
    else return Ackermann(n - 1, Ackermann(n, m - 1));
}

int ackermann = Ackermann(numM, numN);
Console.WriteLine($"Функция Аккермана ({numM}, {numN}) равняется {ackermann}");