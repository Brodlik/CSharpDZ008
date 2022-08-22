// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] FillRandomDoubleArray(int rows = 4, int columns = 4, int leftRange = 0, int rightRange = 10)
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

int[,] array1 = FillRandomDoubleArray();
PrintMatrix(array1);
Console.WriteLine();

int[,] array2 = FillRandomDoubleArray();
PrintMatrix(array2);
Console.WriteLine();

int[,] multiplicatedMatrix = new int[array1.GetLength(0), array1.GetLength(1)];

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int k = 0; k < array2.GetLength(0); k++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int l = 0; l < array2.GetLength(1); l++)
            {
                if (i == k && j == l)
                {
                    multiplicatedMatrix[i, j] = array1[i, j] * array2[k, l];
                }
            }
        }
    }
}
PrintMatrix(multiplicatedMatrix);