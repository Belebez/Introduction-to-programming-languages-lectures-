int Max(int arg1, int arg2, int arg3) // функция поиска максимального из 3 чисел
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 12;
int b1 = 16;
int c1 = 7;
int a2 = 23100;
int b2 = 7650;
int c2 = 75;
int a3 = 1122;
int b3 = 543;
int c3 = 1;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max =  Max(max1, max2, max3);

// аналогичная запись вместо 4 строк

int max = Max
(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)
);

Console.WriteLine(max);


