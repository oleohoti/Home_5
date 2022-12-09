// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.
int[] CreateArray(int size) // создание массива и заполнение рандомными числами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}
void MaxMin(int[]array)
{
    int max=array[0];
    int min=array[0];
    for (int i=0;i<array.Length; i++)
    {
    if (array[i]>max) {max=array[i]; max_ind = i; Console.Write($"{array[i]} ");}
    else if (array[i]<=min){min=array[i]; min_ind = i; Console.Write($"{array[i]} ");}
    else Console.Write($"{array[i] } ");
    }
}

void Middle(int[]array)
{
    int sum=0;
    int mid=0;
    foreach (int item in array)
    {
        sum+=el;
    }
    mid=sum/array.Length;
}
void Arrange(int[]array)
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
}
void Median(int[]array)
{
    int med = 0;
    if (array.Length%2!=0) med=array[array.Length/2+1];
    else med=(array[array.Length/2]+array[array.Length/2+1])/2;
}
void Info(int med, int mid, int max, int min, int max_ind, int min_ind)
{
    int []array=new int[6];
    array[0]=min; 
    array[1]=min_ind;Console.WriteLine($"Минимальное элемент массива {min} находящийся в {min_ind} индексе");
    array[2]=max;
    array[3]=max_ind;Console.WriteLine($"Максимальный элемент массива {max} находящийся в {max_ind} индексе");
    array[4]=mid;Console.WriteLine($"Среднее арифметическое значение массива равно {mid}");
    array[5]=med;Console.WriteLine($"Среднее арифметическое значение массива равно {mid}");
}
int []array = CreateArray(5);