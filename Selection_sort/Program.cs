//----------------Сортировка выбором----------------------------------------

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
int[]CreateArray(int size, int min, int max)
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
//------------------------------------------------------
// public static class Sorting // Сортировка выбором
// {

  /// <summary>
  /// Сортировка методом выбора
  /// </summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив массив</returns>
  int[] SortSelection(int[] collection) //сортировка выбором
  {
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
      int pos = i;
      for (int j = i + 1; j < size; j++)
      {
        if (collection[j] < collection[pos]) pos = j;
      }
      int temp = collection[i];
      collection[i] = collection[pos];
      collection[pos] = temp;
    }
    return collection;
  }

//-----------------------------------------------------------

int[] array = CreateArray(20,min: 0, max: 50);
Show(array);
SortSelection(array);
Show(array);