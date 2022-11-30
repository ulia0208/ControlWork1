// Написать программу, которая из имеющегося массива строк формирует масси из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.


Console.Clear();

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];
int j=0;
for (int i=0; i<n; i++)
{
    Console.Write("Введите строку ");
    string m = Console.ReadLine();
    array[i]=m;
}



int k=0;

Console.Write("[" );
for (int i=0; i<n; i++)
{
    if (i<n-1)
    {
       Console.Write(array[i]+","); 
    }
    else
    {
        Console.Write(array[i]); 
    }
    
    if(array[i].Length<=3)
    {
        k++;
    }
    
}
Console.WriteLine("]" );
Console.WriteLine("Коротких членов " + k );

string[] array2=new string[k];

int f=0;
for (int i=0; i<n; i++)
{
    if(array[i].Length<=3)
    {
        array2[f]=array[i];
        f++;
    }
}


Console.Write("[" );
for (int i=0; i<k; i++)
{
    if (i<k-1)
    {
        Console.Write(array2[i]+",");
    }
    else
    {
        Console.Write(array2[i]);
    }
}
Console.Write("]" );



