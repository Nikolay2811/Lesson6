// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
int Prompt (string message)
{
    Console.Write(message);
    String number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int [] CreateArray (int m)
{
    int [] array = new int[m];
    {
        for (int count =0; count < m; count++)
        {
            array[count]=Prompt( "Ведите число "+ (count + 1) + " => ");
         }
         return array;
    }
}
int m = Prompt( "Введите кол-во чисел => ");
int [] mass = CreateArray(m);
int NumberPos = 0;
for (int count = 0; count < m; count++ )
{
    if (mass [count] >  0 )
    
        NumberPos++;
}   
    
Console.WriteLine("Кол-во положительных чисел= " + NumberPos);
