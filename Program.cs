// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.WriteLine("Введите 1 число:  ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите 2 число:  ");
int number2 = Convert.ToInt32 (Console.ReadLine());
int max = number1;
if ( number2 < max)
    Console.WriteLine( $"Максимальное значение =  {number1}");
        else
   {
         Console.WriteLine( $"Максимальное значение =  {number2}");
   }
