/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] array = new double[7];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
    {
        array[i] = -5.0 + rnd.NextDouble() * (5.0 + 10.0);

    }
double GetMinAndMaxDiff(double[] array)
{
double min = array[0];
double max = array[0];
double diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > max)
        max = array[i];

    if (array[i] < min)
        min = array[i];
    }

diff = max - min;

Console.WriteLine($"min: {min}, max: {max}");

return diff;
}

void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]}, ");
        }

    }

// double min = array[0];
// Console.WriteLine($"min: " + min);
// double max = array[0];
// Console.WriteLine($"max: " + max);
// Console.WriteLine();

double diff = GetMinAndMaxDiff(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {diff}.");


