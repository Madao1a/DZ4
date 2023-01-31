// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] numbers = new double[10];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers [i] = rand.Next(1,10) + rand.NextDouble();
    Console.WriteLine (numbers[i]);
}
Double min = numbers[0];
Double max = numbers[0];


for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i]>max)
    {
        max= numbers[i];
    }
    if (numbers[i]<min)
    {
        min= numbers[i];
    }
}
Console.WriteLine (max-min);
