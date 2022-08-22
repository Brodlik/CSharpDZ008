// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] FillTreeDementionalArray(int sheets = 2, int rows = 2, int columns = 2, int leftRange = 10, int rightRange = 100)
{
    int[,,] randomArray = new int[sheets, rows, columns];
    Random rand = new Random();

    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            for (int k = 0; k < randomArray.GetLength(2); k++)
            {
                randomArray[i, j, k] = rand.Next(leftRange, rightRange + 1);
                if (randomArray[i, j, k] == randomArray[i, j, k])
                {
                    randomArray[i, j, k] = rand.Next(leftRange, rightRange + 1);
                }
            }
        }
    }
    return randomArray;
}

void PrintTreeMatrix(int[,,] treeMatrix)  // метод печати матрицы
{
    for (int i = 0; i < treeMatrix.GetLength(0); i++)
    {
        Console.WriteLine($"Страница № {i}");
        for (int j = 0; j < treeMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < treeMatrix.GetLength(2); k++)
            {
                Console.Write($"{treeMatrix[i, j, k]} [{i}, {j}, {k}]" + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] treeArray = FillTreeDementionalArray();
PrintTreeMatrix(treeArray);
