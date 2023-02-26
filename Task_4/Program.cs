/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int size = 10;
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++) 
{
    array[i] = rand.Next(-100, 100);
}        
for (int i = 0; i < size; i++) 
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int[] prodArray = new int[size / 2];
for (int i = 0; i < size / 2; i++) 
{
    prodArray[i] = array[i] * array[size - i - 1];
}
 for (int i = 0; i < size / 2; i++) 
{
    Console.Write(prodArray[i] + " ");
}
Console.WriteLine();

/* -63 -67 95 12 10
-630 -804
PS C:\Users\poval\Desktop\Homework_4\Task_4> dotnet run
-8 67 -24 -3 -89 16 81 -83 -96 -59
472 -6432 1992 -243 -1424
PS C:\Users\poval\Desktop\Homework_4\Task_4> dotnet run
-62 53 -2 41 38 50 60 -16 -92 11 
-682 -4876 32 2460 1900 */