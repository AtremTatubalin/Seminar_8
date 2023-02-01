//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(1, 10);
        }
    }
    return mat;
}

int[,] Multiplication(int[,] mat_1, int[,] mat_2, int p)
{
    int[,] result = new int[mat_1.GetLength(0), mat_2.GetLength(1)];
    for (int i = 0; i < mat_1.GetLength(0); i++)
    {
        for (int j = 0; j < mat_2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < p; k++)
            {
                sum = sum + (mat_1[i, k] * mat_2[k, j]);
            }
            result[i,j] = sum;
        }
    }
    return result;
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

int a = getUserSize("Введите количество строк 1 матрицы: ");
int b = getUserSize("Введите количество столбцов 1 матрицы: ");
int c = getUserSize("Введите количество строк 2 матрицы: ");
int d = getUserSize("Введите количество столбцов 2  матрицы: ");

if(b == c)
{
    int[,] matrix_1 = CreatArray(a, b);
    int[,] matrix_2 = CreatArray(c, d);

    PrintArray(matrix_1);
    Console.WriteLine();
    PrintArray(matrix_2);
    Console.WriteLine();

    int[,] result = Multiplication(matrix_1, matrix_2, b);
    Console.WriteLine("Результатом произведения матриц будет результирующая матрица: ");
    PrintArray(result);
}
else
{
    Console.WriteLine("Матрицы данного размера нельзя перемножить.");
}
