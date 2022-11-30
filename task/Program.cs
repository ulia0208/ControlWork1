// Написать программу, которая из имеющегося массива строк формирует масси из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.


Console.Clear();

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());

string[] LongArray = new string[n];
int j=0;
for (int i=0; i<n; i++)
{
    Console.Write("Введите строку ");
    string m = Console.ReadLine();
    LongArray[i]=m;
}



int k=0;

Console.Write("[" );
for (int i=0; i<n; i++)
{
    if (i<n-1)
    {
       Console.Write(LongArray[i]+","); 
    }
    else
    {
        Console.Write(LongArray[i]); 
    }
    
    if(LongArray[i].Length<=3)
    {
        k++;
    }
    
}
Console.WriteLine("]" );

Console.WriteLine("Коротких членов " + k );

string[] ShortArray=new string[k];

int f=0;
for (int i=0; i<n; i++)
{
    if(LongArray[i].Length<=3)
    {
        ShortArray[f]=LongArray[i];
        f++;
    }
}


Console.Write("[" );
for (int i=0; i<k; i++)
{
    if (i<k-1)
    {
        Console.Write(ShortArray[i]+",");
    }
    else
    {
        Console.Write(ShortArray[i]);
    }
}
Console.Write("]" );



