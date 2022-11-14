// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void ReadLine() // Функция считывания положительного числа из консоли 
{
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Неверный ввод");
        Console.WriteLine("Введите целое положительное число");
    }
}
void RandomArray(int[] array) // Функция заполнения массива в случайном порядке 
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
}
void PrintArray(int[] array) // Функция вывода массива в консоль 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Copy(int[] input) // Функция копирования и вывода нового массива 
{
    int[] result = new int[input.Length];

    for (int i = 0; i < length; i++)
    {
        result[i] = input[i];
    }
    return result;

}


