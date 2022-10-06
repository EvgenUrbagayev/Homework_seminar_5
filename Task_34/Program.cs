// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


using static System.Console;
Clear();
WriteLine("Введите размер массива:  ");
int lenght = int.Parse(ReadLine()!);
WriteLine("Введите минимальное значение массива больше 100:  ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальное значение массива до 999:  ");
int max = int.Parse(ReadLine()!);


int[] array = GetArray(lenght, min, max);

int evenNumbers = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        evenNumbers += 1;       
    }   
}
WriteLine($"Количество четных элементов: {evenNumbers}");




int[] GetArray(int size, int minValue, int maxValue)

{
    Random rnd = new Random();
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1);
        Write($"{result[i]}, ");
    }
   
    return result;
    
}


