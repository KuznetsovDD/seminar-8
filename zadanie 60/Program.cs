// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)



int[,,] FillArrayUnique(int rows, int columns, int depth, int min = 0, int max = 10)
{
    if ((max - min) < rows * columns * depth)
        return new int[0, 0, 0];

    Random rand = new Random();
    int[,,] result = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int newItem = rand.Next(min, max);
                while (ArrayContain(result, newItem))
                    newItem = rand.Next(min, max);

                result[i, j, k] = newItem;
            }

        }
    }
    return result;
}

bool ArrayContain(int[,,] arr, int findItem)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == findItem)
                    return true;
            }
        }
    }
    return false;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j,k]} ");
            }
        }
        Console.WriteLine();
    }
}

PrintMatrix(FillArrayUnique(2,2,1));