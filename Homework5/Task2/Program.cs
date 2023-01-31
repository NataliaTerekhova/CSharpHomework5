/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

int [] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine(GetSumOfOddIndex(arr));

int GetSumOfOddIndex (int[]array)
{
    int sum = 0; 
    for (int i=0; i<array.Length; i++) 
    { 
        if (i%2==1)
        {
         sum = sum + array[i];
        }
    }
return sum;
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
