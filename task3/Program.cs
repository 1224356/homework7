void printRandArr(int[,] RandArr)
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

int[,] createArr()
{
    int rows = new Random().Next(2, 10), cols = new Random().Next(2, 10);
    int[,] newArr = new int[rows, cols];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            newArr[i,j] = new Random().Next(1, 10);
        }
    }
    printRandArr(newArr);
    return newArr;
}

void findColAvg(int[,] mas)
{
    int sum = 0;
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            sum += mas[i,j];
        }
        Console.WriteLine($"Средее арифметическое колонки с индексом {j}: {Math.Round(Convert.ToDouble(sum)/Convert.ToDouble(mas.GetLength(0)), 2)}");
    } 
}

findColAvg(createArr());