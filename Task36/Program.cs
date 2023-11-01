// Напишите программу, которая находит сумму элементов с нечетными индексами
// в одномерном массиве целых чисел и выводит результат на экран.
// Программа должна иметь метод SumOddElements, который принимает массив
// целых чисел и возвращает сумму элементов с нечетными индексами в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива
// на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".

int[] FillArray(int[] farray)               // Метод заполняет массив случайными
{                                           // числами от 0 до 999.
   for (int i = 0; i < farray.Length; i++)
   {
    farray[i] = new Random().Next(0, 1000);
   }
   return farray;
}

int GetNumber(string msg)                       // Метод выводит на экран 
{                                               // запрос на ввод числа
    System.Console.Write(msg);                  // и преобразует его из
    return Convert.ToInt32(Console.ReadLine()); // string в int
}

void PrintArray (int[] paarray)                 // Метод выводит массив на 
{                                               // печать. Элементы массива
    for (int i = 0; i < paarray.Length; i++)    // выводятся через табуляцию.
    {
        Console.Write($"{paarray[i]}\t");
    }
}

int SumOddElements(int[] soearray)
{
    int sumeven = 0;
    for (int i = 1; i < soearray.Length; i+=2)
    {
        sumeven = sumeven + soearray[i];
    }
    return sumeven;
}

int[] array = new int[GetNumber("Введите колическво элементов массива: ")];
array = FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов массива равна - {SumOddElements(array)}");


