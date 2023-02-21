//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();
double[] array = new double[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
DiffMinMaxArray(array);

void FillArray(double[] collection)
{
    int lenght = collection.Length;
    for (int index = 0; index < lenght; index++)
    {
        collection[index] = new Random().Next(1, 101);
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
    }
}


void DiffMinMaxArray(double[] collect)
{
    double count = collect.Length;
    int i = 0;
    double max = collect[i];
    double min = collect[i];

    for (i = 1; i < count; i++)
    {
        if (min > collect[i]) min = collect[i];
        if (max < collect[i]) max = collect[i];
    }
    double diff = max - min;
    Console.WriteLine(diff);
}