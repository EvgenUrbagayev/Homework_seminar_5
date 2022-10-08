// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;
Clear();
WriteLine("Введите размер массива:  ");
int lenght = int.Parse(ReadLine()!);
WriteLine("Введите минимальное значение массива:  ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальное значение:  ");
int max = int.Parse(ReadLine()!);


int[] array = GetArray(lenght, min, max);

int minElement = array[0];

for(int i = 1; i < array.Length; i += 1)
{
    if(minElement > array[i])
    {
        minElement = array[i];
    }
}
 WriteLine($"Минимальный элемент массива: {minElement}");
 
 
int maxElement = array[0];
for(int i = 1; i < array.Length; i += 1)
{
    if(array[i] > maxElement)
    {
       maxElement = array[i];
    }
}
WriteLine($"Максимальный элемент массива: {maxElement}");


WriteLine($"Разница между максимальным и минимальным элементами массива равна {maxElement - minElement}");



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