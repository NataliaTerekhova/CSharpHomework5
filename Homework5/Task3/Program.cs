/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

int [] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine(GetMax(arr) + " - это максимальное число");
System.Console.WriteLine(GetMin(arr) + " - это минимальное число");
System.Console.WriteLine(GetMax(arr) - GetMin(arr) + " - это разница между максимальным и минимальным числом");

int GetMax(int[]array)
{
    int max=array[0];
    for (int i=1; i<array.Length; i++) 
    {
    
        if (array[i]>max)
        {
            max=array[i];
        }
    }
    return max;
}

int GetMin(int[]array)
{
    int min=array[0];
    for (int i=1; i<array.Length; i++) 
    {
    
        if (array[i]<min)
        {
            min=array[i];
        }
    }
    return min;
}


int[]GetRandomArray(int length)
{
    int[]result = new int[length];
    for (int i=0; i<length; i++)
    {
        result[i]= new Random().Next(1,11);
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
