﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача на 9 max");

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}



//              0  1  2   3  4    5   6  7     8   
int[] array = { 4, 5, 8, 10, 55, 14, 34, 111, 34 };
int n = array.Length;
Console.Write("величина массива - ");
Console.WriteLine(n);
int index = 0;
int find = 111;
while (index < n)
{
    if (array[index] == find)
{
    Console.Write("искомое число - ");
    Console.Write(array[index]);
    Console.WriteLine("Индекс массива равен - ");
    Console.WriteLine(index);     
}       
    index++; 
}



