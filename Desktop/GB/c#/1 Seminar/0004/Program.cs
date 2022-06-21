// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напиши число:");
int num= Convert.ToInt32(Console.ReadLine());
int current;
if (num < 0 ){
    current = num;
    num = num*(-1);
}
else {
    current = -1* num;
}
while (current < num-1){
    current++;
    Console.Write(current+" ");
    
}