double[,] fillArr(int rows, int cols)
{
    Random rnd = new Random();
    double[,] arrF = new double[rows, cols];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            arrF[i,j] = Math.Round(rnd.Next(-50, 50) + rnd.NextDouble(), 2);
        }
    }
    return arrF;
}

double[,] createArr()
{
    Console.WriteLine("Введите параметры матрицы");
    Console.Write("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"m = {m}, n = {n}.");
    return fillArr(m, n);
}

void printRandArr(double[,] RandArr)
{
    for(int i = 0; i < RandArr.GetLength(0); i++)
    {
        for(int j = 0; j < RandArr.GetLength(1); j++)
        {
            Console.Write($"{RandArr[i,j]} \t");
        }
        Console.WriteLine();
    }
}

printRandArr(createArr());