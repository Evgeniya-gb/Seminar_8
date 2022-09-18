// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк массива: ");
int lines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] num_s = new int[lines, columns];
FillArrayRandomNumbers(num_s);
Console.WriteLine();

Console.Clear();

Console.WriteLine("Получившийся массив: ");
PrintArray(num_s);

for (int i = 0; i < num_s.GetLength(0); i++)
{
    for (int j = 0; j < num_s.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < num_s.GetLength(1) - 1; k++)
        {
            if (num_s[i, k] < num_s[i, k + 1]) 
            {
                int temp = 0;
                temp = num_s[i, k];
                num_s[i, k] = num_s[i, k + 1];
                num_s[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив, упорядоченный по убыванию элементов: ");
PrintArray(num_s);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите размер массива: ");
int array = Convert.ToInt32(Console.ReadLine());
int[,] num_s = new int[array, array];
FillArrayRandomNumbers(num_s);
PrintArray(num_s);
int min = Int32.MaxValue;
int line = 0;

for (int i = 0; i < num_s.GetLength(0); i++)
{
    int sum = 0;
    for (int k = 0; k < num_s.GetLength(1); k++)
    {
        sum = sum + num_s[i, k];        
    }
    if (sum < min)
    {
        min = sum;
        line++;
    }
}


Console.WriteLine("Строка с наименьшей суммой элементов : " + (line) + " , сумма элементов равна : " + (min));

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write(array[i, k] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int MatrixSize(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 7);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = MatrixSize("Введите размер матриц: ");
int[,] matrix_a = new int[size, size];
int[,] matrix_b = new int[size, size];
FillArrayRandomNumbers(matrix_a);
FillArrayRandomNumbers(matrix_b);
int[,] product_of_matrix = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            product_of_matrix[i, j] = product_of_matrix[i, j] + (matrix_a[i, k] * matrix_b[k, j]);
        }
    }
}
Console.WriteLine("Матрица a");
PrintArray(matrix_a);
Console.WriteLine();
Console.WriteLine("Матрица b");

PrintArray(matrix_b);
Console.WriteLine();

Console.WriteLine("Произведение двух матриц: ");

PrintArray(product_of_matrix);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int size_1 = InputInt("Введите размер 1: ");
int size_2 = InputInt("Введите размер 2: ");
int size_3 = InputInt("Введите размер 3: ");
int countNumbers = 99;

if (size_1 * size_2 * size_3 > countNumbers)
{
    Console.Write("Массив является слишком большим. ");
    return;
}

int[,,] resultNumbers = CreateArray(size_1, size_2, size_3);

for (int a = 0; a < resultNumbers.GetLength(0); a++)
{
    for (int b = 0; b < resultNumbers.GetLength(1); b++)
    {
        for (int c = 0; c < resultNumbers.GetLength(2); c++)
        {
            Console.WriteLine($"[{a},{b},{c}] - {resultNumbers[a, b, c]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] CreateArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNumbers];
    int num
     = 10;
    for (int a = 0; a < values.Length; a++)
        values[a] = num
        ++;

    for (int a = 0; a < values.Length; a++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[a];
        values[a] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                array[a, b, c] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Введите размер массива: ");
int array = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[array, array];

int num = 1;
int a = 0;
int b = 0;

while (num <= array * array)
{
    numbers[a, b] = num;
    if (a <= b + 1 && a + b < array - 1)
        ++b;
    else if (a < b && a + b >= array - 1)
        ++a;
    else if (a >= b && a + b > array - 1)
        --b;
    else
        --a;
    ++num;
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        Console.Write("[ ");
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
