
 static void Fillarray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           array[i, j] = random.Next(0, 10);
        }
    } 
}
static void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           Console.Write(array[i, j] + "\t");      
        }
     Console.WriteLine();
    }
}





void Задача54()
{
///Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива.
///Например, задан массив:
/* 1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 2 4 1
9 5 3 2
8 4 4 2 */
 int rows = 4;
 int columns = 5;

 int[,] array = new int[rows, columns];
 Fillarray(array);
 PrintArray(array);

 for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           for (int k = 0; k < columns - 1 - j; k++)
           {
              if (array[i, k] < array[i, k +1])
              {
                int temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
            
              }
           }
        }
    } 
 PrintArray(array);
 }

 /*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка */
void Задача56()
{
    int rows = 4;
    int columns = 5;

 int[,] array = new int[rows, columns];
 Fillarray(array);
 PrintArray(array);

     int sumMin = 0;
     int sumMinIndex = 0;
     for (int j = 0; j < columns; j++)
      {
        sumMin += array[0, j];
      }
     Console.WriteLine($"Сумма 1-й строки ровна: {sumMin}");
     
     for (int i = 1; i < rows; i++)
      {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
           sum += array[i, j];
        }
     Console.WriteLine($"Сумма {i+1}-й строки ровна: {sum}");
        if (sum < sumMin)
        {
            sumMin = sum;
            sumMinIndex = i;
        }
      } 
 Console.WriteLine();
 Console.WriteLine($"Минимальная сумма находится в строке {sumMinIndex + 1} и равна {sumMin}");
}
///Задача56();

///Задача54();
void Задача64()
 {
   /*Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
   все натуральные числа в промежутке от M до N, кратные трём.
   M = 1; N = 5. -> ""1, 2, 3, 4, 5""
   M = 4; N = 8. -> ""4, 6, 7, 8""*/
 Console.WriteLine("Введите число M");
 int count = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число N");
 int number = Convert.ToInt32(Console.ReadLine());
 Recursion(count, number);
 Console.WriteLine();

 void Recursion(int count, int number)
 {
   if(count > number) return;
   Console.Write(count + " ");
   count++;
   Recursion(count, number);
 }
  for (int i = 1; i <= number; i++)
 {
   if (i%3 == 0)
   {
    Console.Write(i + " ");
   }  
 }
 Console.WriteLine();

 }
void Задача66()
 {
  /* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
  натуральных элементов в промежутке от M до N.
  M = 1; N = 15 -> 120
  M = 4; N = 8. -> 30 */
 Console.WriteLine("Введите число M");
 int count = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число N");
 int number = Convert.ToInt32(Console.ReadLine());
 Recursion(count, number);
 Console.WriteLine();
 
 void Recursion(int count, int number)
 {
   if(count > number) return;
   Console.Write(count + " ");
   count++;
   Recursion(count, number);
 }
  int sum = 0;
    for (int i = count; i <= number; i++)
  {
   sum = sum + i;
  }
  
     Console.WriteLine("сумма чисел равна: " + sum);
    
 }

void Задача68()
 {
   
  /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
  Даны два неотрицательных числа m и n.
  m = 3, n = 2 -> A(m,n) = 29 */

    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());
    Recursion(m, n);

 int Recursion(int m, int n)
 {
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Recursion(m - 1, 1);
    return Recursion(m - 1, Recursion(m, n - 1));
    Recursion(m, n);
 }
    Console.WriteLine($"A(m,n) = {Recursion(m, n)}");
 }
 //Задача68();
 ///Задача66();
///Задача64();
