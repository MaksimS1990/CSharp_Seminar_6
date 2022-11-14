// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.");

void Fibonacci(int n)
{
    if(n >= 1) Console.Write("0 ");
    if(n >= 2) Console.Write("1 ");
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < n; i++)
    {
       array[i] = array[i-1] + array[i-2];
       Console.Write(array[i] +" ");
    }
    
}

Fibonacci(100);
