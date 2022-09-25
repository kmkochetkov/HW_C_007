// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Заполняем масив случайными числами.
double[,] ComplArray(double[,] col)
{
Random rand = new Random();
int rows = col.GetUpperBound(0) + 1;
int columns = col.Length / rows;
    
    for (int i=0; i< rows; i++)
    {
        for ( int j = 0; j< columns; j++)
        {
            col[i,j] = rand.Next(-100, 100);
        }
    }
return col;
}



// Печать массива введена для контроля работы программы
// Добавлена проверка на крайний элемент массива для печати без последней запятой
void PrintArray(double[,] col)
{
int rows = col.GetUpperBound(0) + 1;
int columns = col.Length / rows;
    
    for (int i=0; i< rows; i++)
    {
        for ( int j = 0; j< columns; j++)
        {
            if (j != columns-1)
            {
            Console.Write($"{col[i,j]}, "); // Не крайний элемент массива в строке
            }
            else
            {
                Console.Write($"{col[i,j]}"); // Крайний элемент массива в строке
            }
        }
        Console.WriteLine();
    }
}



// Основная программа

// Блок ввода размера массива пользователем
// Введена проверка введённого размера. Он должен быть целым, больше 0. Если введено число меньше "0", то размер приравнивается "1"
Console.WriteLine("Задайте размер двумерного массива");
int m = 0;
int n = 0;
    try
    {
        Console.Write("Введите количество строк: ");
        m = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }

    if ( m < 1)
    {
        m=1;
    }

    try
    {
        Console.Write("Введите количество столбцов: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }

    if ( n < 1)
    {
        n=1;
    }




double[,] array = new double[m,n];

double[,] tempArray = ComplArray(array);
PrintArray(tempArray);



// Запрос координат элемента у пользователя
Console.WriteLine("Введите координаты элемента");
int t = 0;
int k = 0;
    try
    {
        Console.Write("Введите номер строки: ");
        t = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }

    if ( t < 1)
    {
        t=1;
    }

    try
    {
        Console.Write("Введите номер столбца: ");
        k = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }

    if ( k < 1)
    {
        k=1;
    }

// Вывод запрашиваемого элемента
Console.WriteLine($"Значение запрашиваемого элемента: {tempArray[t-1,k-1]}");