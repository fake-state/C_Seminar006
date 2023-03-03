// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int SizeOfArray(string text) // Размер массива.
{
    Console.WriteLine(text);
    int m = Convert.ToInt32(Console.ReadLine());
    return m;
}

int Number() // Ввод данных.
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray(int[] array) // Заполнение массива.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: ");
        array[i] = Number();
    }
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

int[] array = new int[SizeOfArray("Введите количество элементов массива: ")];
FillArray(array);
Console.WriteLine($"Количество чисел больше 0: {PositiveNumbers(array)}");