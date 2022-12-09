// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateArray(int size) // создание массива и заполнение рандомными числами
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble()*100;
    }
    return array;
}
void MaxMin(double[]array)// массив вывода элементов массива и нахождение разницы между максивмальным и минимальным значением
{
    double max=array[0];
    double min=array[0];
    foreach (double el in array)
    {
    if (el>max) {max=el; Console.Write($"{el:N2} ");}
    else if (el<=min){min=el; Console.Write($"{el:N2} ");}
    else Console.Write($"{el:N2} ");
    }
    double raz = max-min;
    Console.WriteLine($"разница между максимальным ({max:N2}) и минимальным значением ({min:N2}) массива равна : {raz:N2}");  
}
double[]array = CreateArray(5);
MaxMin(array);