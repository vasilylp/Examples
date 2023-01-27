// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// // и возводит число A в натуральную степень B.

// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16
// //____________Решение _____________________________________________________________________

// double Exponentiation(int numA, int numB) // метод Math.Pow
// {
//     double exponentA = Math.Pow(numA, numB);
//     return exponentA;
// }
// double ExponentiationArr(int numA, int numB) // Метод с циклом While
// {
//     int i = 1;
//     int exponA = 1;
//     while (i <= numB)
//     {
//         exponA = exponA * numA;
//         i++;
//     }
//     return exponA;
// }

// int InputNumber(string message)
// {
//     int number;
//     while (true)
//     {
//         System.Console.Write(message);
//         if (!(int.TryParse(Console.ReadLine(), out number)))
//         {
//             System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
//         }
//         else
//         {
//             break;
//         }
//     }
//     return number;
// }


// int A = InputNumber("Введите число А: ");
// int B = InputNumber("Введите число В: ");
// double sumexponentA = Exponentiation(A, B);            // метод Math.Pow
// System.Console.WriteLine($"{A},{B} -> {sumexponentA}");// метод Math.Pow

// double sumexponA = ExponentiationArr(A, B);           // Метод с циклом While
// System.Console.WriteLine($"{A},{B} -> {sumexponA}");  // Метод с циклом While
//__________________________________________________________________________________________________________________________________
//==================================================================================================================================

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
//__________Решение 1 без обьявления метода________________________________________________________________

// System.Console.Write("Введите число :");
// string? text = Console.ReadLine();
// int sumN = 0;
// int i = 0;
// while (i < text!.Length)
// {
//     sumN += Convert.ToInt32(Convert.ToString(text[i]));
//     i++;
// }
// System.Console.WriteLine($"{text} -> {sumN}");

//___________________Решение 2 с объявлением методов ( через строку)_____________________________

// int SumNumber (int num)
// {
// string text = Convert.ToString(Convert.ToInt32(num));
// int sumN = 0;
// int i = 0;
// while (i < text!.Length)
// {
//     sumN += Convert.ToInt32(Convert.ToString(text[i]));
//     i++;

// }
// return sumN;
// }

// int InputNumber(string str)
// {
//     int number;
//     string? text;
//     while (true)
//     {
//         Console.Write(str);
//         text = Console.ReadLine();
//         if (int.TryParse(text, out number))
//         {
//             break;
//         }

//         System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз!");
//     }
//     return number;
// }

// int n = InputNumber("Введите число N: ");
// int sumNum = SumNumber(n);
// System.Console.WriteLine($"{n} -> {sumNum}");

//___________________Решение 3 с объявлением методов ( математический) _____________________________

// int SumNumber (int num)
// {

// int sumN = 0;
//     int i = 0;
// while (num > 0)
// {
//     sumN = sumN + (num % 10);
//     num = num /10;
//     i++;   
// }
// return sumN;
// }

// int InputNumber(string str)
// {
//     int number;
//     string? text;
//     while (true)
//     {
//         Console.Write(str);
//         text = Console.ReadLine();
//         if (int.TryParse(text, out number))
//         {
//             break;
//         }

//         System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз!");
//     }
//     return number;
// }

// int n = InputNumber("Введите число N: ");
// int sumNum = SumNumber(n);
// System.Console.WriteLine($"{n} -> {sumNum}");
//===============================================================================================================

// // Задача 29: Напишите программу, которая задаёт массив 
// // из 8 элементов и выводит их на экран.

// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]
// //_______________Решение 1____________________________________________________________

// // int[] arr = new int[8];
// // Random rand = new Random();

// // for(int i = 0; i < arr.Length; i++)
// // {
// //      arr[i] = rand.Next(0, 50);
// //      //System.Console.Write(arr[i] + " ");
// // }
// // foreach(var i in arr)
// // {
// //     Console.Write($"{i} ");
// // }

// //_______Решение 2 через Метод_____________________________________________________________________

// string[] ArrayMetod(int lengthArr, int j)
// {

//               string[] arr = new string[lengthArr];
//               Random rand = new Random();
//               int i = 0;
//               while (i < lengthArr)
//               {

//                             int num = rand.Next(0, j);
//                             arr[i] = Convert.ToString(Convert.ToInt32(num));
//                             i++;
//               }

//               return arr;
// }

// string[] arrA = ArrayMetod(8, 50);
// System.Console.WriteLine("[" + string.Join(",", arrA) + "]");
//=============================================================
// int[] array = new int [12];
// Random rand = new Random();

// int sumPositive = 0;
// int sumNegative = 0;

// for (int i = 0; i < array.Length; i++)
// {
//           array[i] = rand.Next(-9,10);
// }
// System.Console.WriteLine("[" + string.Join(",", array)+"]" );

// for (int i = 0; i < array.Length; i++)
// {
//        if (array[i]>0)
//        {
//              sumPositive +=array[i]; 
//        }    
//        else
//        {
//               sumNegative += array[i];
//        }   
// }

// System.Console.WriteLine($"Сумма положительных {sumPositive}, Сумма отрицательных{sumNegative} ");
//--------------------------------------------------------
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
// {
//               int[] arr = new int[size];
//               Random rand = new Random();
//               for (int i = 0; i < arr.Length; i++)
//               {
//                             arr[i] = rand.Next(leftRange, rightRange + 1);
//               }
//               return arr;
// }

// void SumPositiveAndNegativeElements(int[] arr, out int sumP, out int sumN)
// {
//               sumP = 0;
//               sumN = 0;
//               for (int i = 0; i < arr.Length; i++)
//               {
//                             if (arr[i] > 0)
//                             {
//                                           sumP += arr[i];
//                             }
//                             else
//                             {
//                                           sumN += arr[i]; // sumNegative = sumNegative + array[i]
//                             }
//               }
// }

// void PrintArray(int[] arr)
// {
//               System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// int[] array = FillArrayWithRandomNumbers(6, -9, 9);

// PrintArray(array);

// SumPositiveAndNegativeElements(array, out int sumP, out int sumN);

// System.Console.WriteLine($"Сумма положительных = {sumP}, отрицательных = {sumN}");
//=================================================

// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
//------------------------------------------
// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
// {
//               int[] arr = new int[size];
//               Random rand = new Random();
//               for (int i = 0; i < arr.Length; i++)
//               {
//                             arr[i] = rand.Next(leftRange, rightRange + 1);
//               }
//               return arr;
// }

// int[] CheigeArray(int[] arr)
// {
//         int[] arrChange = new int[arr.Length];
//         for (int i = 0; i < arr.Length; i++)
//         {
//              arrChange[i] = arr[i] * -1;         
           
//         }  
//         return arrChange;    
// }

// void PrintArray(int[] arr)
// {
//               System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }
// int[] array = FillArrayWithRandomNumbers(6, -9, 9);
// int[] arrChange = CheigeArray(array);

// PrintArray(array);
// PrintArray(arrChange);


//=========================================================
// Задача 33: Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да
//----------------------------------------------------------
// int[] arrayFill(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }


// void printArray(int[] array)
// {
//     System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
// }



// int inputNumb()
// {
//     System.Console.Write("Введите число: ");
//     int numb = Convert.ToInt32(Console.ReadLine());
//     return numb;
// }


// bool numbCheck(int numb, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (numb == array[i])
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] arr = arrayFill(10, -5, 5);
// printArray(arr);
// int number = inputNumb();

// if(numbCheck(number, arr)) {
//     System.Console.WriteLine("Да");
// } else {
//     System.Console.WriteLine("Нет");
// }
//=================================================================================================

// /*Задача 35: Задайте одномерный массив из 123 случайных
//  чисел. Найдите количество элементов массива, значения 
//  которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5*/

// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
// {
//     int[] arr = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// int CountElements(int[] array, int leftRange, int rightRange)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= leftRange && array[i] <= rightRange)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] array = FillArrayWithRandomNumbers(10, -100, 100);
// PrintArray(array);

// System.Console.WriteLine($"Количество элементов от 10 до 99 в массиве равно {CountElements(array, 10, 99)}");
//==================================================================================================

/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void MultArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int result = array[i] * array[array.Length - i - 1];
        System.Console.WriteLine(result);
    }
    if (array.Length % 2 != 0)
    {
        
        System.Console.WriteLine(array[array.Length / 2]);
    }
}

int[] array = FillArrayWithRandomNumbers(7, 1, 10);
System.Console.WriteLine("Изначальный массив: ");
PrintArray(array);
MultArray(array);