void Fillarray(int[]collection)     // Метод (функция) заполнение массива рандомными числами в пределах периода
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }

}


void Printarray(int[] col)      // Метод (функция) вывода на экран всех чисел из массива
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int [10]; // размер массива равный 10

Fillarray(array);
Printarray(array);