//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Clear();
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
EvenArray(array);

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
    }
}

void EvenArray(int[] collect)
{
    int count = collect.Length;
    int SumCountEven = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] % 2 == 0)
        {
            SumCountEven++;
        }
    }
    if (SumCountEven == 0)
    {
        Console.WriteLine("0");
    }
    else
    {
        Console.WriteLine(SumCountEven);
    }
}