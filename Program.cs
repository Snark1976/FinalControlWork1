internal partial class Program
{
    private static void Main(string[] args)
    {
        string[] array = InputArray();
        OutputArray("Введенный массив: ", array);
        string[] newArray = GetNewArray(array); 
        OutputArray("Новый массив: ", newArray);
    }
    private static string[] InputArray()
    {
        Console.WriteLine("Введите количество элементов в массиве");
        int length = int.Parse(Console.ReadLine()!);
        string[] array = new string[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите {i + 1}-й элемент массива: ");
            array[i] = Console.ReadLine()!;
        }
        return array;
    }

    private static void OutputArray(string message, string[] array)
    {
        Console.Write(message + " [");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if (array.Length - i > 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    private static string[] GetNewArray(string[] array)
    {
        string[] newArray = new string[GetLendthNewArray(array)];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i].Length < 4)
                newArray[j++] = array[i]!;
        return newArray;
    }

    private static int GetLendthNewArray(string[] array)
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i].Length < 4)
                j++;
        return j;
    }
}