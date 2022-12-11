int [,]massiv=new int[2,3];
massiv[0,0]=1;
massiv[0,1]=2;
massiv[0,2]=3;
int rows = massiv.GetUpperBound(0) + 1;    // количество строк
int columns = massiv.Length / rows;        // количество столбцов
// или так
// int columns = numbers.GetUpperBound(1) + 1;
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{massiv[i, j]} \t");
    }
    Console.WriteLine();
}