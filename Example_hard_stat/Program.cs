// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.
int[] CreateArray(int size) // создание массива и заполнение рандомными числами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}
double [] Arrange(double[]array)// Упорядочивание массива
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

        double temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}
void PrintArray(int[] array) // вывод массива целых чисел оператором foreach
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
int[] MaxMin(int[]array,int[] info)// Нахождение минимального  и максимального элемента и их индексов (int)
{
    int max_ind=0;
    int min_ind=0;
    int max = array[max_ind];
    int min = array[min_ind];
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
double[] Middle(double[]array,double[] info)// Нахождение среднего значения массива (желательно double)
{
    int sum=0;
    double mid=0;
    foreach (int el in array)
    {
        sum+=el;
    }
    double sumd=Convert.ToDouble(sum);
    mid=sumd/array.Length;
    info[4]=mid; // необходимо преобразовать массив info в double
    return info;
}
double[] Median(double[]array,double[] info)//Нахождение медианного значения массива
{
    double med = 0;
    int  i_med=array.Length-1;
    if (array.Length%2!=0) med=array[i_med/2];
    else med=(array[i_med/2]+array[i_med/2+1])/2;
    info[5]=med;
    return info;
}
void InfoInput(double[]iar,double[]ar1, double[]ar2) // Формирование массива с инфо и вывод сей
{
    void PrintArrayDouble(double[] array) // вывод массива целых чисел оператором foreach
{
    foreach (double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
    Console.WriteLine($"В данном массиве: максимальным элементом является число {iar[0]}, находящееся в {iar[1]}м индексе; минимальным элементом {iar[2]}, находщееся в {iar[3]}м индексе.");
    Console.WriteLine(" ");
    Console.WriteLine("Cреднее арифметическое равно сумме всех элементов деленное на кол-во всех элементов массива:");
    for(int i =0;i<ar1.Length;i++)
    {
    if (i<ar1.Length-1) Console.Write($"{ar1[i]} + ");
    else Console.WriteLine($"{ar1[i]} / {ar1.Length} = {iar[4]};");
    }
    Console.WriteLine(" ");
    Console.WriteLine($"Медиальным значением созданного массива является:");
    if (ar2.Length%2!=0) Console.WriteLine($"{ar2.Length/2}й индекс упорядоченного* массива, расположенный по середине, и равно {iar[5]}");
    else Console.WriteLine($"среднее арифметическое {ar2.Length/2-1} и {ar2.Length/2} индексов упорядоченного* массива и равно {iar[5]}");
    Console.WriteLine("------------------------------------------");
    Console.Write("* Этот же массив выставленный по порядку: ");
    PrintArrayDouble(ar2);
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int []array1=CreateArray(size);
int[]info0=new int[6];// создали пустой массив для заполнения его информацией
Console.Write("Созданный массив из рандомных чисел: ");PrintArray(array1);Console.WriteLine(" "); // вывод созданного массива
int[]info1=MaxMin(array1,info0);// нахождение максимального и минимального значения массива и запись его вмассив с инфо
double[] info1d = Array.ConvertAll(info1, i => (double)i); // конвертация массива с инфой из int в double для заполнения массива медиальным хначением и средним арифметическим 
double[] array1d = Array.ConvertAll(array1, i => (double)i); // конвертация созданного массива из int в double для точного определения среднего арифметического
double[] info2=Middle(array1d,info1d);// дополнение массива с инфо средним значением 
double[]array2=Arrange(array1d); // упорядочивание массива
double[]info3=Median(array2,info2); // нахождение медианного значения массива
InfoInput(info3, array1d, array2); // метод вывода информации


