Console.Write("Insert a positive number: ");
int N = int.Parse(Console.ReadLine());
int M = N;
if (N / 100 < 1)
 {
   Console.WriteLine($"{N} -> no third digit");
 }
 else
  {
    while (N / 100 >= 1)
     {
      if (N / 100 <= 9)
        {
         int digit3 = N % 10;
         Console.WriteLine($"{M} -> {digit3}");
        }
       N = N / 100;
     }     
  }