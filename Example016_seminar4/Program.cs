// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//______________________________________________________________________________________________

System.Console.WriteLine("Введите пятизначное число :");
string? text = Console.ReadLine();


if (text!.Length == 5)
{
    if (text[0] == text[text.Length - 1] && text[1] == text[text.Length - 2])
    {
        System.Console.WriteLine($"Число {text} палиндром - Да");
    }
    else
    {
        System.Console.WriteLine($"Число {text} не палиндром - Нет");
    }
}
else
{
    System.Console.WriteLine($"{text} не пятизначное число. Введите пятизначное число");
}
