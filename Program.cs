// Задача №1 Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
//Console.WriteLine("Введите 1 число:  ");
//int number1 = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine("Введите 2 число:  ");
//int number2 = Convert.ToInt32 (Console.ReadLine());
//int max = number1;
//if (max == number2)

//Console.WriteLine( $"Значения равны =  {number1}");
// else
//if ( number2 < max)
//      Console.WriteLine( $"Максимум =  {number1}; Минимум = {number2}");
//  else
// {
//       Console.WriteLine( $"Максимум =  {number2}; Минимум = {number1}");
// }



// зАДАЧА №2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Console.WriteLine("Введите 1 число:  ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите 2 число:  ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите 3 число:  ");
//int number3 = Convert.ToInt32(Console.ReadLine());
//int max = number1;
//if (number2 > max) max = number2;
//if (number3 > max) max = number3;

//{
//    Console.WriteLine($"Максимум =  {max}");
//}


//Задача №3 Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//Console.WriteLine("Введите число:  ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number % 2 == 0)

//    Console.WriteLine($"{number} Число четное");
//else
//{
//    Console.WriteLine($"{number} Число нечетное");
//}

//Задача №4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// задача применима к положительным, целым числам.
Console.WriteLine("Введите натуральное число от 1 и более:  ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (n < 1)

    Console.WriteLine("Введите натуральное число от 1 и более");
 else
    {
        while (count < n / 2)
        {
            Console.Write($" {(count + 1) * 2}");
            count++;
        }


        // while (count < -n / 2)
        // {

        //    count++;
        // }
    }

// Дополнительная задача. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа

//Console.WriteLine("Введите трехзначное число:  ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number > 99 && number < 1000)

//   Console.WriteLine($" {number % 10}");

//else
//{
//    Console.WriteLine("Вводите трехзначное число!");
//}
