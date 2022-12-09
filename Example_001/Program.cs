// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] CreateArray(int size) // создание массива и заполнение рандомными числами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}
void CountPrintArray(int[] array) // счетчик нужных чисел и вывод массива оператором foreach
{
    int count=0;
    foreach (int el in array)
    {
    if (el%2==0) {count++; Console.Write($"{el} ");}
    else Console.Write($"{el} ");
    }
    Console.WriteLine($"колличество чётных чисел в массиве: {count}");
}

int []array = CreateArray(5); // присвоение переменной полученному массиву
CountPrintArray(array); // вызов метода для счета нужных и вывода массива