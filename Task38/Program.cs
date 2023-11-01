// Напишите программу для работы с массивом вещественных чисел. Реализуйте
// класс ArrayOperations, который содержит следующие статические методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных чисел
// array и возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных чисел
// array и возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив
// вещественных чисел array и возвращает разницу между максимальным и минимальным
// числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает
// на вход массив array и выводит его элементы с двумя знаками после запятой
// через табуляцию.

double[] FillArray(double[] farray, double max)               // Метод заполняет массив случайными
{                                           // числами от 0 до 999.
    Random random = new Random();
   for (int i = 0; i < farray.Length; i++)
   {
    farray[i] = random.NextDouble() * max;
    farray[i] = Math.Round(farray[i] * 1000) / 1000;
   }
   return farray;
}

int GetNumber(string msg)                       // Метод выводит на экран 
{                                               // запрос на ввод числа
    System.Console.Write(msg);                  // и преобразует его из
    return Convert.ToInt32(Console.ReadLine()); // string в int
}

double GetNumberDouble(string msg)                       // Метод выводит на экран 
{                                               // запрос на ввод числа
    System.Console.Write(msg);                  // и преобразует его из
    return Convert.ToDouble(Console.ReadLine()); // string в int
}

void PrintArrayDouble (double[] paarray)                 // Метод выводит массив на 
{                                               // печать. Элементы массива
    for (int i = 0; i < paarray.Length; i++)    // выводятся через табуляцию.
    {
        Console.Write($"{paarray[i]}\t");
    }
    Console.WriteLine();
}

double FindMax(double[] maxarray)
{
    double maxelement = 0;
    for (int i = 0; i < maxarray.Length; i++)
    {
        if (maxarray[i] > maxelement)
        {
            maxelement = maxarray[i];
        }
    }
    return maxelement;
}

double FindMin(double[] minarray, double maximum)
{
    double minelement = maximum;
    for (int i = 0; i < minarray.Length; i++)
    {
        if (minarray[i] < minelement)
        {
            minelement = minarray[i];
        }
    }
    return minelement;
}

double CalcDifferenceBetweenMaxMin(double[] difarray, double max1)
{
    return (FindMax(difarray) - FindMin(difarray, max1));
}

double[] array = new double[GetNumber("Введите колическво элементов массива: ")];
double maxrange = GetNumberDouble("Введите максимальное значение: ");
array = FillArray(array, maxrange);
PrintArrayDouble(array);
Console.WriteLine($"Max = {FindMax(array)}");
Console.WriteLine($"Min = {FindMin(array, maxrange)}");
Console.WriteLine($"Разница между max и min = {CalcDifferenceBetweenMaxMin(array, maxrange)}");

