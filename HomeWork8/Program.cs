// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
//------------------------------Решение---------------------------------------
//-----------------1.Создание двумерного массива--------------------------------

int[,] CreateMatrix(int rows, int cols)
{
              Random rand = new Random();
              int[,] matrix = new int[rows, cols];
              for (int i = 0; i < rows; i++)
              {
                            for (int j = 0; j < cols; j++)
                            {
                                          matrix[i, j] = rand.Next(0, 10);
                            }
              }
              return matrix;

}
//---------------------2.Печать созданного массива--------------------------------------

void PrintMatrix(int[,] matrix)
{
              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                          System.Console.Write(matrix[i, j] + "  ");
                            }
                            System.Console.WriteLine();
              }
}
//-----------------------------3.Ищем строку массива с наименьшей суммой элементов-------

// void MinSumRows(int[,] matrix)
// {
              
//               int numberRows = 0;
//               Dictionary<int, int> sumRows = new Dictionary<int, int>();
//      for (int i = 0; i < matrix.GetLength(0); i++)
//               {
//                             int SumRows = 0;
//                             for (int j = 0; j < matrix.GetLength(1); j++)
//                             {
//                                           SumRows += matrix[i,j];
//                                           numberRows = i;
//                             }
//                             sumRows.Add(SumRows,numberRows);
//               }     
//             foreach (var letter in sumRows.Keys)
//              {
//             Console.WriteLine($"{letter} : {sumRows[letter]}");
//              }


//               Dictionary<int, int>.KeyCollection keys = sumRows.Keys;
//               int minSumRows = sumRows.Keys.ElementAt(0);
//               int numR = 0;
//               int k = 1;
//               while (k < matrix.GetLength(0))
//               {
//                   if ( sumRows.Keys.ElementAt(k) < minSumRows)
//                   {
//                        minSumRows = sumRows.Keys.ElementAt(k); 
//                        numR = sumRows[sumRows.Keys.ElementAt(k)];    
//                   }
//                   k++;
//               }   
//               Console.WriteLine($"{minSumRows} => {numR}");
// }

Dictionary<int, int> SumRows(int[,] matrix)
{
              
              int numberRows = 0;
              Dictionary<int, int> sumRows = new Dictionary<int, int>();
     for (int i = 0; i < matrix.GetLength(0); i++)
              {
                            int SumRows = 0;
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                          SumRows += matrix[i,j];
                                          numberRows = i;
                            }
                            sumRows.Add(SumRows,numberRows);
              }     
         return sumRows;
}
           
 void PrintDictionary(Dictionary<int, int> dict)
 {
              foreach (var letter in dict.Keys)
             {
            Console.WriteLine($"{letter} : {dict[letter]}");
             }


 }          
           
 void MinSumRows(Dictionary<int, int> dict, int[,] matrix)
 {
              Dictionary<int, int>.KeyCollection keys = dict.Keys;
              int minSumRows = dict.Keys.ElementAt(0);
              int numR = 0;
              int k = 1;
              while (k < matrix.GetLength(0))
              {
                  if ( dict.Keys.ElementAt(k) < minSumRows)
                  {
                       minSumRows = dict.Keys.ElementAt(k); 
                       numR = dict[dict.Keys.ElementAt(k)];    
                  }
                  k++;
              }   
              Console.WriteLine($"{minSumRows} => {numR}");

 }         

              
//------------------------------Вызов методов --------------------------------------------

int[,] matr = CreateMatrix(4, 4);
PrintMatrix(matr);
System.Console.WriteLine();
//MinSumRows(matr);
SumRows(matr);
PrintDictionary(SumRows(matr));
MinSumRows(SumRows(matr),matr);

