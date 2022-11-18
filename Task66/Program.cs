// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число N");
int numN = Convert.ToInt32(Console.ReadLine());

int Sum(int num, int num2)
{
    if (num == num2) return num2;
    if (num < num2) return num + Sum(num + 1, num2);
    else return num + Sum(num - 1, num2);

}

int sum = Sum(numM, numN);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");