//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int m = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Вычисление функции Аккермана
/// </summary>
/// <returns></returns>
/// 
int Ack(int n, int m)
{
  if (n == 0)
  {
    return m + 1;
  } else if (m == 0)
  {
    return Ack(n - 1, 1);
  }

  return Ack(n - 1, Ack(n, m - 1));
}

if(n > 0 && m > 0)
{
  Console.WriteLine("Значение функции Аккермана =  " + Ack(n, m));
} else 
{
  Console.WriteLine("Чмсла m и n должны быть положительными");
}