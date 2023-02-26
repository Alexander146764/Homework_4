/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int size = 15;
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++) 
{
    array[i] = rand.Next(100, 1000);
}        
Console.WriteLine("Массив:");
for (int i = 0; i < size; i++) 
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < size; i++) 
{
    if (array[i] % 2 == 0) 
    {
        count++;
    }
}        
Console.WriteLine("Количество четных чисел в массиве: " + count);

/* Массив:
964 141 629 810 455 485 694 730 304 955
Количество четных чисел в массиве: 5
PS C:\Users\poval\Desktop\Homework_4\Task_1> dotnet run
Массив:
239 174 796 927 267 791 805 254 156 262 668 775 152 151 314 
Количество четных чисел в массиве: 8 */
