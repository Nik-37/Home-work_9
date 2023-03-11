//Задача 64: Задайте значение M и N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от M до N. Выполнить с помощью рекурсии.

Console.Write("Введите число M:  ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int N = Convert.ToInt32(Console.ReadLine());

/// <summary>
/// Печатаем все натуральные числа от M до N
/// </summary>
/// <param name="M">первое число</param>
/// <param name="N">второе число</param>
/// <returns></returns>

string PrintNumbers(int M, int N)
{
  // Базовый
  if (M == N) 
  {
    return M.ToString();
  }

  // Рекурсивный
  return (M + ", " + PrintNumbers(M + 1, N));
}

if(M < 0)
{
  Console.WriteLine("Число M не может быть отрицательным");
}

if(M > N)
{
  Console.WriteLine("Число M не может быть больше числа N");
}  else
{
  Console.WriteLine("Натуральные числа от M до N = " + PrintNumbers(M, N));
}


