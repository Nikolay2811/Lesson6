// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
Console.WriteLine("Ведите коэфиценты для функций y = k1 * x + b1, y = k2 * x + b2");

int Prompt (string message)
{
    Console.Write(message);
    String number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}
double k1 =Prompt("Введите коэфицент k1 => ");
double b1 =Prompt("Введите коэфицент b1 => ");
double k2 =Prompt("Введите коэфицент k2 => ");
double b2 =Prompt("Введите коэфицент b2 => ");

void Calculate ( double k1, double b1, double k2, double b2)
{
    if(k1==k2 && k1!=0 && k2!=0)
    {Console.WriteLine("Прямые паралельны");}
    else
   { if (k1 == 0 || k2 == 0 )
    {Console.WriteLine("Коэфиценты к не должны быть равны 0");}
    else
    {double x =(b2-b1) / (k1-k2);
    double y = k1*x + b1;
    Console.WriteLine($"Кординаты точки пересечения  ({x} ;{y})" );
   }
   }
}
Calculate (  k1,  b1,  k2,  b2);