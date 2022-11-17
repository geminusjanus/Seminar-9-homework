Console.WriteLine("Введите целое число N");
int numN = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers (int num)
{
    if(num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}  

NaturalNumbers(numN);