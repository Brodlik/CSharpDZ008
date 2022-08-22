// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

int[,] FillRandomDoubleArray(int rows = 4, int columns = 5, int leftRange = 0, int rightRange = 10)
{
    int[,] randomArray = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(0); j++)
        {
            randomArray[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return randomArray;
}


void PrintMatrix(int[,] matrix)  // метод печати матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array = FillRandomDoubleArray();
PrintMatrix(array);
Console.WriteLine();

int minSum = 1000;
int lineNumber = 0;


for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        lineNumber++;
    }
}
Console.WriteLine($"Наименьшая сумма {minSum} находится в строке {lineNumber}");

