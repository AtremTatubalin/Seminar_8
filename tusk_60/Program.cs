//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int getUserSize(string massege)
{
    Console.Write(massege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[,,] CreatArray(int size)
{
    int[,,] result = new int[size, size, size];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int Size = getUserSize("Введите длину стороны массива: ");
int[,,] Array = CreatArray(Size);
PrintArray(Array);