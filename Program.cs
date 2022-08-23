/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76*/

int[] numbers = new int[20];
int max = 0;
Rdnumbers(numbers);
int min = numbers[0];

void Rdnumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 99);
    }
}

for (int i = 0; i < numbers.Length; i++) // Найдем максимальное число
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

for (int i = 1; i < numbers.Length; i++) // Найдем минимальное число
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine(max - min);
Console.WriteLine("[{0}]", string.Join(", ", numbers));