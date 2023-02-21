//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumNotEvenArray(array);

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(-100, 101);
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

void SumNotEvenArray(int[] collect)
{
    int count = collect.Length;
    int SumCount = 0;
    for (int i = 0; i < count; i++)
    {
        if (i % 2 != 0)
        {
            SumCount = SumCount + collect[i];
        }
    }
    Console.WriteLine(SumCount);
}