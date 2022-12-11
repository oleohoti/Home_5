//Задача 30: - HARD необязательная Напишите программу, которая на вход получает размерность массива. Далее заполняет его случайными уникальными числами и выводит на экран. Далее производим сортировку массива от большего к меньшему и выводим на экран. Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. Встроенные методы работы со списками использовать нельзя.
int[] CreateArray(int size) // создание массива и заполнение рандомными числами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}
void PrintArray(int[] array) // вывод массива оператором foreach
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
int[] CreateArray2(int size,int [] array) // заполнение массива уникальными числами
{
    for (int i=0; i<size; i++) // Этот цикл для нахождения квадрата чисел массива
{
    for (int j=0; j<size; j++) // этот цикл для перемножения элементов массвива самих на себя
    {
        if(array[i]==array[j]) array[j] = new Random().Next(-99, 100);
        else array[i]=array[j];
    }

}
return array;
}
// int [] Arrange(int[]array)// Упорядочивание массива
// {
//     for (int i = 0; i < array.Length-1; i++)
//     {
//         int minPosition = i;
        
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if (array[j]>array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }

//         int temporary = array[i];
//         array[i]=array[minPosition];
//         array[minPosition] = temporary;
//     }
//     return array;
// }
// int [] blend(int []array)// рандомим-миксим
// {
//     int [] box = new int(array.Length);
// for (int i = 0; i < array.length; i++)
// {
//     if(array[i]%10==2){}
// }
// }
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int []array0 = CreateArray(size);
PrintArray(array0);
int []array1= CreateArray2(size,array0);
PrintArray(array1); 