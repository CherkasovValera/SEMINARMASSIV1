// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.WriteLine("Введите 1 число:  ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите 2 число:  ");
int number2 = Convert.ToInt32 (Console.ReadLine());
int max = number1;
if (max == number2)

Console.WriteLine( $"Значения равны =  {number1}");
else
if ( number2 < max)
    Console.WriteLine( $"Максимум =  {number1}; Минимум = {number2}");
        else
   {
         Console.WriteLine( $"Максимум =  {number2}; Минимум = {number1}");
   }
