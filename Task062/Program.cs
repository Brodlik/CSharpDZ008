// // Задача 62. Заполните спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:

// //  1  2  3 4
// // 12 13 14 5
// // 11 16 15 6
// // 10  9  8 7


int[,] circleMatrix = new int[4, 4];

int fill = 1;
int i = 0;
int j = 0;

while (fill <= circleMatrix.GetLength(0) * circleMatrix.GetLength(1))
{
  circleMatrix[i, j] = fill;
  fill++;
  if (i <= j + 1 && i + j < circleMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= circleMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > circleMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

void PrintMatrix(int[,] circleMatrix)  // метод печати матрицы
{
    for (int i = 0; i < circleMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < circleMatrix.GetLength(1); j++)
        {
            Console.Write(circleMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
PrintMatrix(circleMatrix);

