// Вид 1:
void Method1()
// Ничего не принемает и не возвращает
{
    System.Console.WriteLine("Автор ...");
}
// Чтобы вызвать данный метод нужно указать его имя+()
// Method1();

// Вид 2:
void Method2(string msg, int count)
{
    for (int i = 0; i < count; i++)
        System.Console.WriteLine(msg);
}
// Чтобы вызвать данный метод нужно указать его имя+(то что мы хотим написать)
// Method2("Какой-то текст", 4);

// Вид 3:
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//System.Console.WriteLine(year);

// Вид 4:
string Method4(int count, string c)
{
    string result = String.Empty; // Пустая строка
    for (int i = 0; i < count; i++) result = result + c;
    return result;
}
// System.Console.WriteLine(Method4(4,"Прога ")); // Выводим определенный текст count раз

// Цикл в цикле - таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    //System.Console.WriteLine();
}

// ==== Работа с текстом
// Дан текст, тексте нужно все пробелы заменить черточками. Маленькие буквы "к" на большие "К", а большие "С" на "с".

string text = "- Я думаю, - сказал Князь, улыбаясь, - что "
            + " ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля. "
            + " Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
// идексы      012345
// s[2] // e 
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenghts = text.Length;
    for (int i = 0; i < lenghts; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

// System.Console.WriteLine(Replace(text, ' ', '_'));
// System.Console.WriteLine();

// System.Console.WriteLine(Replace(text,'к','К'));
// System.Console.WriteLine();

// System.Console.WriteLine(Replace(text, 'С', 'с'));

// Отсортировать массив по убыванию или увеличению

int[] array = { 6, 8, 3, 2, 1, 4, 5, 9 };
//              0  1  2  3  4  5  6  7
void Position(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // -1 чтобы не искал последнюю переменную
    {
        int minPos = i; // Задаем индекс минимального значения равный 0
        for (int j = i + 1; j < array.Length; j++) // Начинаем поиск индекса минимального значения начиная с j=1
        {
            if (array[j] < array[minPos]) minPos = j; // Если текущее значение массива меньше значения с минимальным индексом 
                                                      // то задаем новый мин индекс
        }
        int timep = array[i]; // сохраняем текущее значение массива во временную переменную timep (6)
        array[i] = array[minPos]; // текущему значению массива присваеваем минимальное значение массива с индексом minPos (1)
        array[minPos] = timep; // Завершаем обмен передав сщхраненное значение в значение мин пос (6)
    }
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i],5}");
    System.Console.WriteLine();
}

Print(array);
Position(array);
Print(array);