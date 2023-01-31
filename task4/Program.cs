// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20
int[] numbers = new int[15];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(18,22);
    Console.Write (numbers[i]);
}
int per = 0;
for (int j = 0; j < numbers.Length && per == 0; j++)
{
    if (numbers[j] == 20)
    {
        numbers[j] = numbers[j]*10;
        per = 1;
    }
}

Console.WriteLine();

for (int f = 0; f < numbers.Length; f++)
{
    Console.Write (numbers[f ]);
}

