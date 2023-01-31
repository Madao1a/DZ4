// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] numbers = new int[8];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1,10);
}
int sum =0;
for (int j = 0; j < numbers.Length; j++)
{
    if (j%2!=0)
    {
        sum = sum+numbers[j];
    }
}
Console.WriteLine (sum);