/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int[,] Creat2DRandomArray (int min, int max, int m, int n)
{
    int[,] newArray = new int[m, n];
for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j ++)
        {   
            newArray[i, j] = new Random().Next(min, max);
        }
        
    }
    return newArray;
}
void Show2DRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = array.GetLength(1)-1; j >= 0; j--)
        {
            int temp;
            for (int k = 0; k < j; k++)
            {
            if (array [i,k] > array [i,k+1])
            {
                temp = array [i,k];
                array [i,k] = array [i,k+1];
                array [i,k+1] = temp;
            } 
            }Console.Write( array[i, j]+ " "); 
            }  
        
        Console.WriteLine();
    }
        
}

int[,] array = Creat2DRandomArray(0, 10, 4, 4);
Show2DRandomArray(array);
Console.WriteLine();
SortArray(array);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int[,] Creat2DRandomArray (int min, int max, int m, int n)
{
    int[,] newArray = new int[m, n];
for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j ++)
        {   
            newArray[i, j] = new Random().Next(min, max);
        }
        
    }
    return newArray;
}
void Show2DRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void StringMinSumm(int[,] array)
{
    int min = 100000;
    int minI = 0;
     for (int i = 0; i < array.GetLength(0); i ++)
    {   
        
        int summ  = 0;
        for (int j = 0; j < array.GetLength(1); j ++)
        {   
            summ = summ + array[i,j];
        }
        if (summ < min)
            { 
                min = summ;
                minI = i+1;
            }
    }    Console.WriteLine($"min summa in string {minI}");

}

int[,] array = Creat2DRandomArray(0, 10, 4, 4);
Show2DRandomArray(array);
Console.WriteLine();
StringMinSumm(array);
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] Creat2DRandomArray (int min, int max, int m, int n)
{
    int[,] newArray = new int[m, n];
for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j ++)
        {   
            newArray[i, j] = new Random().Next(min, max);
        }
        
    }
    return newArray;
}
void Show2DRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplicationArray (int[,] array, int[,] array2)
{
     for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
           array [i,j] = array[i,j] * array2[i,j];
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }          

}

int[,] array2 = Creat2DRandomArray (0, 10, 2, 2);
int[,] array = Creat2DRandomArray(0, 10, 2, 2);
Show2DRandomArray(array);
Console.WriteLine();
Show2DRandomArray(array2);
Console.WriteLine();
MultiplicationArray(array, array2);
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
int[,,] Creat3DRandomArray (int min, int max, int x, int y, int z)
{
    int[,,] newArray = new int[x, y, z];
for (int i = 0; i < x; i ++)
    {   
        int maxArray = newArray[0, 0, 0];
        newArray[0, 0, 0] = new Random().Next(min, max);
        if (newArray[i, 0, 0] == maxArray)
            {maxArray = newArray[i, 0, 0];}
        for (int j = 0; j < y; j ++)
        {   
            for (int k = 0; k < z; k ++)
            {   
                int maxnumber = newArray [i, j, k];
                if (newArray [i, j, k] == maxnumber)
                newArray[i, j, k] = maxnumber + new Random().Next(min, max);
            }  
        }
    }
    return newArray;
}
*/
/*
int[,,] Creat3DRandomArray (int min, int max, int x, int y, int z)

{
    int [] arr = new int [x*y*z];
    for (int i = 0; i < x*y*z; i++) {
        arr[i] = new Random().Next(min, max);
    }
    int maxNumber = arr[0];
    for (int i = 0; i < x*y*z; i ++) {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    for (int i = 0; i < x*y*z; i++) {
        for (int j = i + 1; j < x*y*z; j++) {
            if (arr[i] == arr[j]) {
                maxNumber++;
                arr[j] = maxNumber;
            }
        }
    }
    Console.WriteLine();
    int[,,] newArray = new int[x, y, z];
    int g = 0;
    for (int i = 0; i < x; i ++) {                                                                               
        for (int j = 0; j < y; j ++) { 
            for (int k = 0; k < z; k ++) {
                newArray[i,j,k] = arr[g];
                g++;
            }    
        }
    }
    return newArray;
}
void Show3DRandomArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            for (int k = 0; k < array.GetLength(2); k ++)
            {
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] array = Creat3DRandomArray(10, 50, 2, 2, 2);
Show3DRandomArray(array);
Console.WriteLine();
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int [,] SpiralMatrix (int m, int n)
{
int[,] spiralMatrix = new int[m, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
return spiralMatrix;
}


void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" 0{array[i,j]} ");

      else Console.Write($" {array[i,j]} ");
    }
    Console.WriteLine();
  }
}
int [,] array = SpiralMatrix(4, 4);
WriteArray(array);