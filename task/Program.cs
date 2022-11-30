// Написать программу, которая из имеющегося массива строк формирует масси из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.


Console.Clear();

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];

for (int i=0; i<n; i++)
{
    Console.Write("Введите строку ");
    string m = Console.ReadLine();
    array[i]=m;
}



Console.Write("[" );
for (int i=0; i<n; i++)
{
    Console.Write(array[i]+",");

    
}
Console.Write("]" );
