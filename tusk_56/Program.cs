//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int getUserNumber(string massege)
{
    Console.Write(massege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[,] CreatMatrix(int size)
{
    int[,] mat = new int[size, size];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(0, 10);
        }
    }
    return mat;
}

int MinSum(int[,] mat)
{
    int min = 0;
    int sum = 0;
    int row = 0;
    for (int i = 0; i < mat.GetLength(1); i++)
    {
        min = min + mat[0, i];
    }
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            sum = sum + mat[i, j];
        }
        if (sum < min)
        {
           row = i; 
        }
        sum = 0;
    }
    return row;
}

void PrintArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}

int Size = getUserNumber("Введите сторону прямоугольного массива: ");
int[,] Matrix = CreatMatrix(Size);

int minRow = MinSum(Matrix);
PrintArray(Matrix);
Console.WriteLine($"Номер строки с минимальной суммой элементов: {minRow + 1}");