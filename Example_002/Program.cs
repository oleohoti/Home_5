// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] CreateArray(int size) // создание массива и заполнение рандомными числами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}
void FindSums(int[] array) // массив с нахождением суммы элементов, стоящих на нечетных позициях и вывода массива
{
    int sum = 0;
    for (int i=0;i<array.Length;i++)
    {
        if (i%2!=0){sum += array[i]; Console.Write($"{array[i]} ");}
        else Console.Write($"{array[i]} ");
    }

    Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {sum}");
}
int []array = CreateArray(4);
FindSums(array);