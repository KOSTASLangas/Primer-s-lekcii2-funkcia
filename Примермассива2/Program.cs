// Имеется одномерный массив array из n элементов, требуется найти элемент массива,
//который равен find.
int [] array = {1,2,3,4,5,6,7,4,8,9,4};

int n = array.Length;
int find =4;
int index =0 ;
while (index<n) 
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break; // в этом цикле есть повт. элементы. Эта команда остановит цикл после нахождения первого из них
    }
    index ++;
}
