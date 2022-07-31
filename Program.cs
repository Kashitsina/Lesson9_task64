  // Задайте значение M и N.напишите программу ,которая выведет все натуральные числа в промежутке от М до N


  int numberN = 4;
  int numberM = 8;


  Recursion(numberN , numberM);
  Console.WriteLine();


  void Recursion(int numberN, int numberM)
  {
    if (numberN == numberM +1  ) return ;
     
    Console.Write(numberN + "  ");
    numberN ++;
    Recursion( numberN, numberM);
    
  }
   

