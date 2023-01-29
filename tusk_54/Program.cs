//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.Clear();

int getUserSize(string massege)
{
    Console.Write(massege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[,] CreatArray(int row, int col)
{
    int[,] mat = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            mat[i, j] = new Random().Next(1, 10);
        }
    }
    return mat;
}

int[,] Order(int[,] mat)
{
    int tmp = 0;
    int max = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            max = mat[i, j];
            for (int b = 0; b < mat.GetLength(1); b++)
            {
                int ord = mat[i, b];
                if (ord < max)
                {
                    tmp = mat[i, j];
                    mat[i,j] = ord;
                    mat[i, b] = tmp;
                }
            }
        }
    }
    return mat;
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

int row = getUserSize("Введите количество строк в матрице: ");
int col = getUserSize("Введите количество столбцов в матрице: ");
int[,] Matrix = CreatArray(row, col);

PrintArray(Matrix);
Matrix = Order(Matrix);
Console.WriteLine();
PrintArray(Matrix);