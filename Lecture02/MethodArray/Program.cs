int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

int n = array.Length; // длина массива

int find = 8; // переменная для поиска нужного числа в массиве

int index = 0;

while (index > n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // остановим поиск после первого нахождения нужного числа
    }
    index++;
}