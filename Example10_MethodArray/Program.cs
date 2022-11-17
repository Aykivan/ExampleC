int[] array = { 1, 22, 34, 45, 52, 26, 75, 28 };

int n = array.Length;
int find = 75;

int index = 0;

while (index < n)
{
    if (find == array[index])
    {
        System.Console.WriteLine(index);
        break; //прерви
    }
    index++;
}