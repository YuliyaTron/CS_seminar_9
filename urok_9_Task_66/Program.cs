/* Задача 66
Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
Console.Write("Введите первое число M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите второе число N: ");
int numN = int.Parse(Console.ReadLine());

int temp = numM;

if (numM > numN) 
{
  numM = numN; 
  numN = temp;
}
Console.WriteLine();

PrintSumm(numM, numN, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}
Console.WriteLine();


