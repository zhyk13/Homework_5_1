// Напишите программу, которая подсчитывает количество четных элементов
// в массиве целых положительных трехзначных чисел и выводит результат
// на экран.
// Программа должна иметь метод CountEvenElements, который принимает массив
// целых положительных трехзначных чисел и возвращает количество четных
// элементов в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы
// массива на экран.
// При выводе элементы массива должны быть разделены символом
// табуляции "\t".
// Если аргументы командной строки не переданы, программа использует
// массив по умолчанию, который содержит следующие
// значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.


using System.ComponentModel.DataAnnotations;

int GetNumber(string msg)                         // Метод принимает и выводит на
{                                                 // печать сообщение, принимает  
    System.Console.Write(msg);                    // число в виде строки и преобразует  
    return Convert.ToInt32(Console.ReadLine());   // его в число.  
}

int[] FillArray(int[] arr)                      // Метод принимает на вход массив и 
{                                               // заполняет его случайными 
    for (int i = 0; i < arr.Length; i++)        // положительными трехзначными числами.
    {
        arr[i] = new Random().Next(100, 1000);
    }

    return arr;
}

void PrintArray(int[] PrArr)                           // Метод выводит массив
{                                                      // на печать. 
    Console.Write("[");
    for (int i = 0; i < PrArr.Length-1; i++)
    {
        Console.Write($"{PrArr[i]},\t");
    }
    Console.WriteLine($"{PrArr[PrArr.Length-1]}]");
}

int CountEven (int[] coevarr)
{
    int count = 0;
    for (int i = 0; i < coevarr.Length; i++)
    {
        if (coevarr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = new int[GetNumber("Введите колическво элементов массива: ")];
array = FillArray(array);
PrintArray(array);
Console.WriteLine($"Число четных элементов массива - {CountEven(array)}");

