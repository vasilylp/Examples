// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 
//_______________________________________________________________________________________

// System.Console.WriteLine("Введите пятизначное число :");
// string? numb = Console.ReadLine();
// int lenghtNum = numb!.Length;
// int i = 0;
// while(i < lenghtNum)
// {
//     i++;
// }
// System.Console.WriteLine($"{numb} -> {i}");
// Решение 2___________________________________________________________________


// int InputNumber(string str)
// {
//     int number;
//     string text;
//     while (true)
//     {
//         Console.Write(str);
//         text = Console.ReadLine();
//         if (int.TryParse(text, out number))
//         {
//             break;
//         }
//         System.Console.WriteLine("Введено не корректное число");
//     }
//     return number;

// }

// void Counter(string number)
// {
//     int answer = 0;
//     for (int i = 0; i < number.Length; i++)
//     {
//         answer++;
//     }
//     System.Console.WriteLine(answer);
// }

// int numb = InputNumber("Введите число: ");
// Counter(Convert.ToString(numb));

//___________________________________________________________________________

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 12
//_______________________________________________________________________________________________
int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено не число");
    }
    return number;
}

void Factorial(int count)
{
    int answer = 1;
    for (int i = 1; i < count + 1; i++)
    {
        answer *= i;
    }
    System.Console.WriteLine(answer);
}

int N = InputNumber("Введите число N:");
Factorial(N);
