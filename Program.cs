﻿//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу,которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)  Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int EvenNumber(int[] arr)
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) quantity++;
        else quantity += 0;
    }
    return quantity;
}

int[] array = CreateArrayRndInt(10, 100, 1000);
PrintArray(array);

int evenNumber = EvenNumber(array);
Console.WriteLine($" — {evenNumber}");