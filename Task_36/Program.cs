// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



using static System.Console;
Clear();
WriteLine("Введите размер массива:  ");
int lenght = int.Parse(ReadLine()!);
WriteLine("Введите минимальное значение массива:  ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальное значение:  ");
int max = int.Parse(ReadLine()!);


int[] array = GetArray(lenght, min, max);

int sum = 0;

for(int i = 0; i < array.Length; i += 2)
{
    sum += array[i]; 
}
WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");




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