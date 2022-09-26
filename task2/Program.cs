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
    int rows = new Random().Next(1, 10), cols = new Random().Next(1, 10);
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

void findElem(int i, int j, int[,] mas)
{
    try
    {
        Console.WriteLine($"Элемент массива в позиции [{i}, {j}]: {mas[i,j]}");
    }
    catch (System.IndexOutOfRangeException)
    {
        Console.WriteLine($"Элемент в позиции [{i}, {j}] отсутствует в массиве");
    }
}

Console.Write("Введите индекс строки: ");
int iRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int iCol = Convert.ToInt32(Console.ReadLine());
findElem(iRow, iCol, createArr());
