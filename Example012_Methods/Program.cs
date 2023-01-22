//Вид1______________________________________________________________________
void Method1()
{
    Console.WriteLine("Автор Василий");
}
//Method1();


//Вид2____________________________________________________________________
void Method2(string msg)
{
   Console.WriteLine(msg);
}

//Method2("Текст сообщения");
void Method21(string msg, int count)
{
   int i = 0;
   while(i < count)
   {
    System.Console.WriteLine(msg);
    i++;
   }
}
//Method21("Техт",4);
//Method21(count:4, msg:"Техт");



//Вид3______________________________________________________________
int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);


//Вид4___________________________________________________________
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10,"Res");
// System.Console.WriteLine(res);

   string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

//string res = Method4(10,"Res");
//System.Console.WriteLine(res); 

//_____________________________________________________

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
      System.Console.WriteLine($"{i} x {j} = {i * j}");  
    }
    System.Console.WriteLine();
}