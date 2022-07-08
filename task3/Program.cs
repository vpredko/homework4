﻿int[] CreateRandomArray(int min, int max)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write ("->  [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");

}

Console.WriteLine ("Введите певрое число");
int start = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите последнее число");
int end = Convert.ToInt32 (Console.ReadLine());

int[] myArray = CreateRandomArray(start, end);
ShowArray(myArray);



