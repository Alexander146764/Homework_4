/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int size = 16;
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++) 
{
    array[i] = rand.Next(-100, 100);
}        
Console.WriteLine("Массив:");
for (int i = 0; i < size; i++) 
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int sum = 0;
for (int i = 1; i < size; i+=2) 
{
    sum+=array[i];   
}        
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);

/* Массив:
15 -46 64 -57 -18 -50 -33 97 27 -92
Сумма элементов, стоящих на нечётных позициях: -148
PS C:\Users\poval\Desktop\Homework_4\Task_2> dotnet run
Массив:
88 -92 18 -54 32 71 43 88 -56 6
Сумма элементов, стоящих на нечётных позициях: 19
PS C:\Users\poval\Desktop\Homework_4\Task_2> dotnet run
Массив:
15 -71 -15 5 -88 14 18 -71 15 74 -71 82 53 -13 -55 18 
Сумма элементов, стоящих на нечётных позициях: 38 */