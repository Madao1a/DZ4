//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] numbers = new int[8];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= rand.Next(100,999);
    Console.WriteLine (numbers[i]);
}
int count=0;
for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j]%2==0)
    {
        count++;
    }
}
Console.WriteLine (count);