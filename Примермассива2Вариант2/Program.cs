// Второй способ решения задачи из папки "Примермассива2"

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

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1 ; // если нет в массиве искомого элемента, то не выводит индекс 0
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10]; // размер массива равный 10

Fillarray(array);
Printarray(array);
Console.WriteLine();

int pos = Indexof(array, 4);
Console.WriteLine(pos);
