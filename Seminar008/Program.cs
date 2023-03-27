//=================Семинар 008=========================================

// Задача 53: 
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//-------------------------------------------------------------------------------------------

// int[,] FillMatrix(int rows, int cols)
// {
//     int[,] matr = new int[rows, cols];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = rand.Next(1, 10);
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write(matr[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void MatrixEdit(int[,] matrix)
// {
//     int temp = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         temp = matrix[0,j];
//         matrix[0, j] = matrix[matrix.GetLength(0)-1,j];
//         matrix[matrix.GetLength(0)-1,j] = temp;

//     }
    
// }

// int[,] matrix = FillMatrix(3, 4);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// MatrixEdit(matrix);
// PrintMatrix(matrix);
//-----------------------------------------------------------------------------------

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

// int[,] FillMatrix(int rows, int cols)
// {
//     int[,] matr = new int[rows, cols];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = rand.Next(1, 10);
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write(matr[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] ReverseMatrix(int[,] matrix)
// {
//     int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];
//     for (int i = 0; i < matrix2.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             matrix2[i, j] = matrix[j, i];
//         }
//     }
//     return matrix2;
// }

// int[,] matrix = FillMatrix(3, 4);
// PrintMatrix(matrix);
// System.Console.WriteLine();

// PrintMatrix(ReverseMatrix(matrix));
//---------------------------------------------------------------------------
// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// int[,] FillMatrix(int rows, int cols)
// {
//     int[,] matr = new int[rows, cols];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = rand.Next(1, 10);
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write(matr[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }



// int[,] matrix = FillMatrix(3, 4);
// PrintMatrix(matrix);
// System.Console.WriteLine();


// int[] resalt = new int[10];
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//               resalt[matrix[i,j]]++;
//         }
//     }
// System.Console.WriteLine(String.Join(" ", resalt));
// for (int i = 0; i < resalt.Length; i++)
// {
//               if (resalt[i] != 0)
//               {
//                  System.Console.WriteLine($"{i} встречается {resalt[i]} раз");           
//               }
              
// }
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}
//------------------------------------------------------------------------------------------------------
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
//----------------------------------------------------------------------------------------------
int[,] matr = FillMatrix(4, 4);
PrintMatrix(matr);
int min = matr[0, 0];
int minIndexI = 0;
int minIndexJ = 0;
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (matr[i, j] < min)
        {
            min = matr[i, j];
            minIndexI = i;
            minIndexJ = j;
        }
    }
}
int[,] resiult = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
int countI=0;
for (int i = 0; i < matr.GetLength(0); i++)
{
    int countJ=0;
    if (i==minIndexI) continue;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
       if (j==minIndexJ) continue;
       resiult[countI,countJ]=matr[i,j];
       countJ++;
    }
    countI++;
}

PrintMatrix(resiult);


