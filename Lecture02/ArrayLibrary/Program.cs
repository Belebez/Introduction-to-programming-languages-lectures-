
// метод void не возвращает значение, т.е мы не используем return

void FillArray(int[] collection)  // метод заполнения массива случайными цифрами
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);  // на место индекса помещаем случайное число от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)  // метод вывода массива
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int IndexOf(int[] collection, int find)  // функция для поиска нужного числа
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // используем -1 для того чтобы, если в массиве не будет нужного нам числа, метод вернул нам это значение, если используем ноль, то это есть значение в массиве, что нам не нужно
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

int[] array = new int[10]; // создай новый масиив, в котором будет 10 элементов(по умолчанию он будет заполнен нулями)

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 5);
Console.WriteLine(pos);