//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.WriteLine("Напиши 1 число:");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напиши 2 число:");
int num2= Convert.ToInt32(Console.ReadLine());

if(num1<num2){
    Console.WriteLine("Первое Число меньшее");
Console.Write(num1);
}
if(num1>num2){
    Console.WriteLine("Первое Число больше второго");
    Console.Write(num2);

}
if(num1 == num2){
    Console.WriteLine("Числа равны друг другу");
    
}