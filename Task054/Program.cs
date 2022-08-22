// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] FillRandomDoubleArray (int rows =4, int columns =4, int leftRange = 0, int rightRange=10)
{
    int [,] randomArray = new int [rows, columns];
    Random rand = new Random ();
    for (int i=0; i<randomArray.GetLength(0); i++)
    {
        for (int j=0; j<randomArray.GetLength(0); j++)
        {
            randomArray [i,j] = rand.Next (leftRange, rightRange+1);
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


int [,] array = FillRandomDoubleArray();
PrintMatrix(array);
Console.WriteLine();


for (int i = 0; i < array.GetLength(0); i++) //Цикл для сортировки элементов от меньшего к большему
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[i, k] > array[i, k + 1]) 
            {
                int min = 0;
                min = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = min;
            }
        }
    }
}

PrintMatrix(array);