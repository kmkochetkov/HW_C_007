// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



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

