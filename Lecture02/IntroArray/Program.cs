int Max(int arg1, int arg2, int arg3) // функция поиска максимального из 3 чисел
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 11, 211, 32, 44, 25, 65, 27, 98, 1 }; // задали массив

int result = Max
(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])   
);

Console.WriteLine(result);


