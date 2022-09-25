// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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


// Вычисление среднего арифметического по столбцу
double[] ArithmMeanRaw(double[,] col)
{
    int rows = col.GetUpperBound(0) + 1;
    int columns = col.Length / rows;
    double[] mean = new double[columns];
    double sumRows = 0;     
        for (int j=0; j< columns; j++)
        {
            for (int i = 0; i< rows; i++)
            {
                sumRows = sumRows + col[i,j]; 
            }
        mean[j] = sumRows / columns;
        sumRows = 0;
    }
return mean;
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




double[,] array = new double[m,n];  // Создание исходного массива [m*n]

double[,] tempArray = ComplArray(array); // временный массив, копия исходного
PrintArray(tempArray);
double[] tempMean = ArithmMeanRaw(tempArray);  // временный массив, копия массива средних значений столбцов

Console.WriteLine("Средние арифметические значения элементов столбцов:");
for ( int j = 0; j< tempMean.Length; j++)
    {
      //  double t=tempMean[j];
        Console.Write("{0:f2}",tempMean[j]);  // Вывод на консоль средних значений, с точностью до второго знака после запятой
        Console.Write("; ");
    }
Console.WriteLine("");


