// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// //-----------------------------Решение----------------------------------------

// double InputNumber(string message)
// {
//               double number;
//               while (true)
//               {
//                             System.Console.Write(message);
//                             if (!(double.TryParse(Console.ReadLine(), out number)))
//                             {
//                                           System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
//                             }
//                             else
//                             {
//                                           break;
//                             }
//               }
//               return number;
// }

// void IntersectionPoint(double b1, double k1, double b2, double k2)
// {
//               double x = (b2 - b1) / (k1 - k2);
//               double y = (k1 * x) + b1;
//               System.Console.WriteLine($"b1 = {b1}, k1 = {k1},b2 = {b2}, k2 = {k2} ");
//               System.Console.WriteLine($"Координаты пересечения двух прямых ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
// }


// double b1 = InputNumber("Введите значение b1 : ");
// double k1 = InputNumber("Введите значение k1 : ");
// double b2 = InputNumber("Введите значение b2 : ");
// double k2 = InputNumber("Введите значение k2 : ");
// IntersectionPoint(b1, k1, b2, k2);
//==============================================================================================================
// // Задача 41: Пользователь вводит с клавиатуры M чисел. 
// //Посчитайте, сколько чисел больше 0 ввёл пользователь.

// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3
// //----------------------Решение--------------------------------

// int[] InputNumbers(string str, int m, string str1)
// {
//               int[] array = new int[m];
//               int number;
//               string? text;
//               for (int i = 0; i < m; i++)
//               {
//                             Console.Write($"{str} {m} {str1}, {i + 1}-е число :");
//                             text = Console.ReadLine();
//                             if (int.TryParse(text, out number))
//                             {
//                                           array[i] = number;

//                             }
//                             else
//                             {
//                                           System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз!");
//                                           i = i - 1;
//                             }
//               }
//               return array;
// }

// void PrintArray(int[] arr)
// {
//               System.Console.WriteLine("[ " + String.Join(", ", arr) + " ]");
// }



// void MoreZero(int[] array)
// {
//               int numMoreZero = 0;
//               for (int i = 0; i < array.Length; i++)
//               {
//                             if (array[i] > 0)
//                             {
//                                           numMoreZero++;
//                             }
//               }
//               System.Console.WriteLine($"Чисел больше 0 : {numMoreZero}");
// }


// int[] arr = InputNumbers("Введите", 6, "чисел");
// PrintArray(arr);
// MoreZero(arr);
//==================================== Семинар 7====================================

// // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// // m = 3, n = 4.
// // 1 4 8 19
// // 5 -2 33 -2
// // 77 3 8 1
// int[,] FillMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matr = new int[rows, cols];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = rand.Next(0, 100);
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

// System.Console.WriteLine("Введите m и n: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrix(m, n);
// System.Console.WriteLine();
// PrintMatrix(matrix);
//=====================================================================================
// // Задача 48: Задайте двумерный массив размера m на n, каждый элемент 
// // в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// // rows = 3, cols = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5
// //-------------------------------Решение-------------------------------------
// int[,] FillMatrix(int rows, int cols)
// {
//     int[,] matr = new int[rows, cols];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = i + j;
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

// System.Console.WriteLine("Введите m и n: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrix(m, n);
// System.Console.WriteLine();
// PrintMatrix(matrix);
//====================================================================

// Решение в группах задач:
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//-----------------------------------------------------------------------

// // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, 
// // и замените эти элементы на их квадраты

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
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if ((i % 2 != 0) && (j % 2 != 0))
//             {
//                 matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
//             }
//         }

//     }
// }

// int[,] matrix = FillMatrix(3, 3);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// MatrixEdit(matrix);
// PrintMatrix(matrix);
//================================================================================
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//------------------------------------------------------------------------------

int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
    return matr;
}

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

int MatrixEdit(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i == j))
            {
                result += matrix[i, j];
            }
        }
    }
    return result;
}


System.Console.WriteLine("Введите rows и cols: ");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] array2d = FillMatrix(rows, cols);
PrintMatrix(array2d);
System.Console.WriteLine();
System.Console.WriteLine(MatrixEdit(array2d));