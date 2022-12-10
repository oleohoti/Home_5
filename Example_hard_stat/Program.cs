// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.
int[] CreateArray(int size) // создание массива и заполнение рандомными числами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}
int [] Arrange(int[]array)// Упорядочивание массива
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]<array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}
void PrintArray(int[] array) // вывод массива оператором foreach
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
int[] MaxMin(int[]array,int[] info)// Нахождение минималььного  и максимального элемента и их индексов
{
    int max =0;
    int min =0;
    int max_ind=0;
    int min_ind=0;
    for (int i=0;i<array.Length; i++)
    {
    if (array[i]>max) {max=array[i]; max_ind = i;}
    else if (array[i]<=min){min=array[i]; min_ind = i;}
    }
    info[0]=max;
    info[1]=max_ind;
    info[2]=min;
    info[3]=min_ind;
    return info;
}
int[] Middle(int[]array,int[] info)// Нахождение среднего значения массива
{
    int sum=0;
    var mid=0;
    foreach (int el in array)
    {
        sum+=el;
    }
    mid=sum/array.Length;
    info[4]=mid;
    return info;
}
int[] Median(int[]array,int[] info)//Нахождение медианного значения массива
{
    var med = 0;
    var i_med=array.Length-1;
    if (array.Length%2!=0) med=array[i_med/2];
    else med=(array[i_med/2]+array[i_med/2+1])/2;
    info[5]=med;
    return info;
}
void InfoInput(int[]iar,int[]ar1, int[]ar2) // Формирование массива с инфо и вывод сей
{
    Console.WriteLine($"В данном массиве: максимальным элементом является число {iar[0]}, находящееся в {iar[1]} индексе; минимальным элементом {iar[2]}, находщееся в {iar[3]} индексе; среднее арифметическое равно: {iar[4]}; медиальным значением массива является {iar[5]} ");
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int []array1=CreateArray(size);
int[]info0=new int[6];// создали пустой массив для заполнения его информацией
Console.Write("Созданный массив из рандомных чисел: ");
PrintArray(array1);
int[]info1=MaxMin(array1,info0);
int[]info2=Middle(array1,info1);
int []array2=Arrange(array1);
int[]info3=Median(array2,info2);
InfoInput(info3, array1, array2);
Console.Write("** Этот же массив выставленный по порядку: ");
PrintArray(array2);
