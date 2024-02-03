int[] array = { -1, -2, -3, -4, 0, 1, 2, 3, 4, 5 };
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");