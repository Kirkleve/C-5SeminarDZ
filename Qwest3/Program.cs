/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("Задайте массив вещественных чисел ");
double[] randomMass = new double[10];
RandomArray(randomMass);
WriteArray(randomMass);
double count = 0;
double max = 0;
double min = 1000;
for (int i = 0; i< randomMass.Length; i++)
{
    if ( randomMass[i] > max )
    {
        max = randomMass[i];
        count++;
    }
    if ( randomMass[i] < min)
    {
        min = randomMass[i];
        count++;
    }
}
double difference = max - min;

Console.WriteLine($"Максимальное значение " + max);
Console.WriteLine($"Минимальное значение " + min);
Console.WriteLine($"Разница между максимальным и минимальным значением равна " + difference);



void RandomArray(double[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(99,1000);
    }
}

void WriteArray(double[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}
