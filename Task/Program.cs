void ArrayMetod(string[] array1, string[] array2)
{
    int Maxlenght = 3;
    int count = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= Maxlenght)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    Array.Resize(ref array2, count);
    Console.WriteLine($"Конечный массив: [{string.Join(", ", array2)}]");
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[n];
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write("Введите строку массива: ");
        array1[i] = Console.ReadLine();
    }
Console.WriteLine($"Начальный массив: [{string.Join(", ", array1)}]");
string[] array2 = new string[array1.Length];
ArrayMetod(array1, array2);