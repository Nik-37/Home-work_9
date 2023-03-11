//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите число M:  ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int N = Convert.ToInt32(Console.ReadLine());

int SumOfRange(int M, int N)
{
  if (M == N)
  {
    return M;
  } 

  return M + SumOfRange(M + 1, N);
}

if(M < 0)
{
  Console.WriteLine("Число M не может быть отрицательным");
}
if(M > N)
{
  Console.WriteLine("Число M не может быть больше числа N");
}  else

Console.WriteLine("Cумма натуральных элементов в промежутке от M до N =  " + SumOfRange(M, N)); 