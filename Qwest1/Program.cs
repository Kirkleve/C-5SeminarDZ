/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


int [] random = new int[20];
RandomArray(random);
WriteArray(random);
Console.WriteLine(random);
int count = 0;
for (int i = 0; i< random.Length; i++)
{
    if ( random[i] % 2 == 0 )
    count++;
}
Console.WriteLine(count);

void RandomArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(99,1000);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}