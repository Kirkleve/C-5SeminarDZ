/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] arrayMass = new int[Length];
RandomArray(arrayMass);
WriteArray(arrayMass);
int count = 0;

for (int i = 0; i< arrayMass.Length; i++)
{
    if ( arrayMass[i] % 2 == 1 )
    {
        count = count + arrayMass[i];
        Console.WriteLine(count);
    }
}
Console.WriteLine($"Сумма отрицательных чисел ровна " + count);

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