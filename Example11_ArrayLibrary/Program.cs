void FillArray(int[] collection) //FillArray - заполнить массив, в данном случае без вывода его результатов на экран
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //это метод который будет выводить числа массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //специально задаем данное значение, чтобы, если отсуствует искомый элемент, мы видели это в виде -1
    while (index < count)
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

int[] array = new int[10]; //Создает новый массив с 10тью числами, и заполняет его нулями

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos= IndexOff(array, 4);
System.Console.WriteLine(pos);