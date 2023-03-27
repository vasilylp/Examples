// ____________________Быстрая сотрировка__________________________________________
using static System.Console;
using static System.String;
//----------------------------------------------------------------


//public static class Infrastructure
//{
  /// <summary>
  /// Метод создания и заполнения массива
  /// </summary>
  /// <param name="size">Размер нового массива</param>
  /// <param name="min">Нижняя граница заполнения</param>
  /// <param name="max">Верхняя граница заполнения</param>
  /// <returns>Новый массив</returns>
  int[] CreateArray(int size, int min, int max)
  {
    return Enumerable.Range(1, size)
           .Select(item => Random.Shared.Next(min, max))
           .ToArray();
  }

  /// <summary>
  /// Вывод массива в консоль
  /// </summary>
  /// <param name="array">Исходный массив</param>
  /// <param name="separator">Символ-разделитель элементов массива</param>
  /// <returns>Исходный массив</returns>
  int[] Show(int[] array, string separator = ",")
  {
    string output = Join(separator, array);
    WriteLine($"[{output}]");
    return array;
  }




//public static class Sorting

  int[] SortQuick(int[] collection, int left, int right) // быстрая сортировка
  {
    int i = left;
    int j = right;

    int pivot = collection[Random.Shared.Next(left, right)];
    while (i <= j)
    {
      while (collection[i] < pivot) i++;
      while (collection[j] > pivot) j--;

      if (i <= j)
      {
        int t = collection[i];
        collection[i] = collection[j];
        collection[j] = t;
        i++;
        j--;
      }
    }
    if (i < right) SortQuick(collection, i, right);
    if (left < j) SortQuick(collection, left, j);
    return collection;
  }

//----------------------------------------------------------------------------

int size = 10;
int[] array = CreateArray(size,min: 0, max: 50);
Show(array);
SortQuick(array,0,size-1);
Show(array);
//System.Console.WriteLine("+");         
