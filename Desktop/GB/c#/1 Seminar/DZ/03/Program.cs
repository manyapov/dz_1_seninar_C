//Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.WriteLine("Напишете 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишете 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишете 3 число");
int num3 = Convert.ToInt32(Console.ReadLine());

// int max=0;
// if (num1>num2) max=num1;
// if ( num2 >num3) max=num2;
// if (num3>num1) max=num3;

// Console.WriteLine("Число Максивальное =");
// Console.WriteLine(max);
int max=0;
if (num1>max) max=num1;
if ( num2 >max) max=num2;
if (num3>max) max=num3;

Console.WriteLine("Число Максивальное =");
Console.WriteLine(max);