int [] CreateArray(int size)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input Value of {i+1} element:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Input Array size: ");
int length = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateArray(length);
ShowArray(myArray);