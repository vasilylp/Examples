// ===Работа с текстом
// Дан текст. Нужно заменить все пробелы черточками |, маленькие к заменить К, c заменить C
//________________________________________________________________________________________

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            +"Ежели бы вас послали вместо нашего милого Винцегроде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'с', 'С');
System.Console.WriteLine(newText);
