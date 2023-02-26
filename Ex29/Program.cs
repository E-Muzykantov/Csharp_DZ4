// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());


bool ChekSize (int size)
{
    if (size > 0) return true;
    
    Console.WriteLine("Размер массива не может равняться или быть меньше 0");
    return false;
}

int[] CreateArray (int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-20, 21);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.WriteLine($"{string.Join(", ", array)} -> [{string.Join(", ", array)}]");
}

if(ChekSize(num)) 
{
    int[] array = CreateArray(num);
    PrintArray(array);
}