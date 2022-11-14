// See https://aka.ms/new-console-template for more information

int[] CreateArray(int lengthArray, int startInterval, int endInterval)
{
    int[] array = new int[lengthArray];
    Random random = new Random();

    for (int i = 0; i < lengthArray; i++)
    {
        array[i] = random.Next(startInterval, endInterval + 1);
    }

    return array;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.WriteLine(" , ");
    }
}

int[] ReverseArray(int[] input)
{
    int[] array = new int[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        array[i] = input[input.Length - i - 1];
    }

    return array;
}

var array = CreateArray(10, 0, 100);
Print(array);

var newArray = ReverseArray(array);
Print(newArray);
