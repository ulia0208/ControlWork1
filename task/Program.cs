﻿// Написать программу, которая из имеющегося массива строк формирует масси из строк, длина которых меньше либо равна 3 символа.
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
    Console.Write(array[i]+",");
    if(array[i].Length<=3)
    {
        k++;
    }
    
}
Console.Write("]" );
Console.WriteLine("Коротких членов" + k );
