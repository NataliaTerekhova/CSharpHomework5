/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int [] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine(CountEvenNumbers(arr));

int CountEvenNumbers (int[]array)
{
   int count=0;
   for (int i=0; i<array.Length; i++) 
   {
    if (array[i]%2==0)
    {
        count++;
    }
   }
    return count;    
}

int[]GetRandomArray(int length)
{
    int[]result = new int[length];
    for (int i=0; i<length; i++)
    {
        result[i]= new Random().Next(100,1000);
    }
    return result;
}

void PrintArray (int[]arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item + ", ");
    }
    System.Console.WriteLine();
}