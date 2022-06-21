// See https://aka.ms/new-console-template for more information
Console.WriteLine("ВЕДИТЕ от 1 до 3:");
int day= Convert.ToInt32 (Console.ReadLine());
// int Poned = 1
// int Vtor = 2
// int Sreda = 3
if (day <1||day>3)
{
Console.WriteLine("ВЕДИ КОРЕКТНО СУКА 1 до 3:");

}
else{
    if(day ==1){
        Console.WriteLine("Гавнопонедельник");
    }
    if(day ==2){
        Console.WriteLine("Гавно_ВТОРНИК");
    }
    if(day ==3){
        Console.WriteLine("ГавноСЕРЕДА");
    }
}


