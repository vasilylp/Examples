// Сравнение времени работы Рекурсии и циклов при расчете чисел Фибоначчи------

decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
              fRec++;
              return n == 0 || n == 1 ? 1: FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIterecion(int n)
{
              fIte++;
              decimal result = 1;
              decimal f0 = 1;
              decimal f1 = 1;
              for (int i = 2; i <= n; i++)
              {
                      result = f0 + f1;

                      f0 = f1;
                      f1 = result;
                      fIte++;     
              }
              return result;
}
DateTime dt = DateTime.Now;
// Console.ReadLine();
for (int n = 10; n < 30; n++)
{
    Console.WriteLine($"FibonacciIterecion({n}) = {FibonacciIterecion(n)} fIte = {fIte.ToString("### ### ###"),-15}");   
    fIte = 0;      
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

System.Console.WriteLine();           
dt = DateTime.Now;
for (int n = 10; n < 30; n++)
{
      System.Console.WriteLine($"(FibonacciRecursion{n}) = {FibonacciRecursion(n)} fRec ={fRec.ToString("### ### ###"),-15}"); 
      fRec = 0;       
}
// Console.ReadLine();
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);