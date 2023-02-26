// ------------ ДОМАШНИЕ ЗАДАНИЕ К СЕМИНАРУ 7 --------------


//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round((new Random().NextDouble()), 2);

        
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of row:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random(). Next(0, 100);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void IndexesOfElement(int[,] array)
{
    Console.Write("Input a index of the element by row:  ");
    int i1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a index of the element by column:  ");
    int j1 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == i1 && j == j1) i1 = i; j1 = j;
        }
        Console.WriteLine($"The element with the requested indexes is {array[i1, j1]}");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
IndexesOfElement(newArray);
*/

// Не понимаю куда записать else ...

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of row:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random(). Next(0, 100);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void IndexesOfElement(int[,] array)
{
    Console.Write("Input a index of the element by row:  ");
    int i1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a index of the element by column:  ");
    int j1 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == i1 && j == j1) 
                {   
                    i1 = i; j1 = j;
                    Console.WriteLine($"The element with the requested indexes is {array[i1, j1]}");  
                }
                else Console.WriteLine("The entered indexes are missing in the array");
            }   
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
IndexesOfElement(newArray);
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of row:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random(). Next(1, 9);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArithmeticMeanOfColumn(int[,] array)
{
    int sumOfColumn = 0;
    int numberOfElementsInColumn = 0;
    int arithmeticMeanOfColumn = 0;
     
     for (int j = 0; j == 0; j++)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumOfColumn = (array[i, j] + sumOfColumn);  
            numberOfElementsInColumn = array.GetLength(0);
            arithmeticMeanOfColumn = sumOfColumn / numberOfElementsInColumn;
        }
           
    Console.WriteLine($"Result {arithmeticMeanOfColumn}");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
ArithmeticMeanOfColumn(newArray);
*/
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of row:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random(). Next(1, 9);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");

    Console.WriteLine();
}

int[] ArithmeticMeanOfColumn(int[,] array)
{
    int[] array2 = new int [array.GetLength(1)];

    for (int j = 0; j == 0; j++)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sumOfColumn = 0;
            int numberOfElementsInColumn = 0;
            int arithmeticMeanOfColumn = 0;
            
            sumOfColumn = (array[i, j] + sumOfColumn);  
            numberOfElementsInColumn = array.GetLength(0);
            arithmeticMeanOfColumn = sumOfColumn / numberOfElementsInColumn;
        }    
       
    return array2;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int[] newArray2 = ArithmeticMeanOfColumn(newArray);
ShowArray(newArray2);