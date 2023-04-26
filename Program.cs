//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//3a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.WriteLine("Введите первое целое число");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе целое число");
//int num2 = Convert.ToInt32(Console.ReadLine());
//int max = 0;
//int min = 0;
//if(num1 > num2)
//{
//max = num1;
//min = num2;
//Console.WriteLine($"Max = {max}"); 
//Console.WriteLine($"Min = {min}");
//}    
//else   
//max = num2;
//min = num1;
//Console.WriteLine($"Max = {max}"); 
//Console.WriteLine($"Min = {min}");

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Console.WriteLine("Введите три числа");
//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());
//int max_num = num1;
//if (num2 > max_num)
// max_num = num2;
//if (num3 > max_num)
// max_num = num3;
//Console.WriteLine("Mаксимальное из этих чисел:");
//Console.WriteLine(max_num);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

//Console.WriteLine("Введите целое число");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num % 2 == 0)
//Console.WriteLine("Число является чётным");
//else
//Console.WriteLine("Число не является чётным");


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

//Console.WriteLine("Введите целое число");
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 1;
//while (count <= num) 
//{
//  if(count % 2 == 0)
//{
//  Console.Write(count);
//Console.Write(" ");
//}
//count++;
//}







//Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
//456111 -> 5
//78 -> 8
//9146548 -> 1
//3 -> нет

//Console.WriteLine("Введите целое число");
//int num = Convert.ToInt32(Console.ReadLine());
//int result = 0;
//if(num < 10)
//Console.WriteLine("No");

//else 
//{
//while (num > 99)
//{
//num = num / 10;
//}
//result = num % 10;

//Console.WriteLine("Второе число слева:");
//Console.WriteLine(result);
//}    