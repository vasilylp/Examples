//------------------------Семинар 6---------------------------------------

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

// void ReversArray(int[]arr)
// {
//               int temp;
//               for (int i = 0; i < arr.Length /2 ; i++)
//               {
//                     temp = arr[i];
//                     arr[i] = arr[arr.Length-i-1] ;
//                     arr[arr.Length-i-1] =arr[i]  ;     
//               }
//               return arr;
// }


// int[] array = FillArrayWithRandomNumbers(10, -10, 10);
// PrintArray(array);


///==============================================================================
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
//---------------------------Решение---------------------------------------------------

// int InputNumber(string str)
// {
//               int number;
//               string? text;
//               while (true)
//               {
//                             Console.Write(str);
//                             text = Console.ReadLine();
//                             if (int.TryParse(text, out number))
//                             {
//                                           break;
//                             }

//                             System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз!");
//               }
//               return number;
// }


// bool TriangleCheck(int numb1, int numb2, int numb3)
// {
//               if ((numb1 + numb2) > numb3 && (numb1 + numb3) > numb2 && (numb3 + numb2) > numb1)
//               {
//                             return true;
//               }

//               return false;
// }


// int firstNum = InputNumber("Введите первое число :");
// int secondNum = InputNumber("Введите второе число :");
// int thirdNum = InputNumber("Введите третье число :");

// if (TriangleCheck(firstNum, secondNum, thirdNum))
// {
//               System.Console.WriteLine("Да, такой треугольник существует");
// }
// else
// {
//               System.Console.WriteLine("Нет, такого треугольника не существует");
// }

//=============================Рекурсия=======================================================
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101InputNumber("Введите второе число :");
// 3  -> 11
// 2  -> 10
//--------------------------------------Решение--------------------------------------------------
// void GetBinaryView(int num)
// {
//               if (num <= 0) return;
//               GetBinaryView(num / 2);
//               System.Console.Write(num % 2);
// }

// System.Console.Write("Введите число :");
// int n = Convert.ToInt32(Console.ReadLine());
// GetBinaryView(n);
//========================================================================================

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//---------------------------------Решение-------------------------------------
// int InputNumber(string str)
// {
//               int number;
//               string? text;
//               while (true)
//               {
//                             Console.Write(str);
//                             text = Console.ReadLine();
//                             if (int.TryParse(text, out number))
//                             {
//                                           break;
//                             }

//                             System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз!");
//               }
//               return number;
// }

// void Fibonachi(int n)
// {
//               string[] fibb = new string[n];
//               int fibbN = 0;
//               int i = 0;
//               while (i < n)
//               {
//                             if (i == 0) fibbN = 0;
//                             else if (i == 1 || i == 2) fibbN = 1;
//                             else if (i > 2) fibbN = Convert.ToInt32(Convert.ToString(fibb[i - 1])) + Convert.ToInt32(Convert.ToString(fibb[i - 2]));
//                             fibb[i] = Convert.ToString(Convert.ToInt32(fibbN));
//                             i++;
//               }
//               Console.WriteLine("[" + string.Join(",", fibb) + "]");

// }



// int n = InputNumber("Введите первое число : ");
// Fibonachi(n);




//============================================================================================
// Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.
//---------------------------Решение-----------------------------------------

// int[] RandomArrayCreation(int size, int leftValue, int rightValue)
// {
//     int[] arr = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(leftValue, rightValue + 1);
//     }
//     return arr;
// }

// int[] ArrayCopying(int[] array)
// {
//     int[] arrayCopy = new int[array.Length];
//     for (int i = 0; i < arrayCopy.Length; i++)
//     {
//         arrayCopy[i] = array[i];
//     }
//     return arrayCopy;
// }


// int[] arr = RandomArrayCreation(5, 0, 10);
// Console.WriteLine("[" + string.Join(",", arr) + "]");
// int[] arr2 = ArrayCopying(arr);
// Console.WriteLine("[" + string.Join(",", arr2) + "]");
//=====================================================================================