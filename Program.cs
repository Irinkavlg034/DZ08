
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
Задача56();

///Задача54();