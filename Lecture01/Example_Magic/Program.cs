//перед каждым запуском будем очищать консоль, для лучшего вывода
Console.Clear();

//вводим начальные данные

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

//выведим значения в терминал

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

//создаём случайные точки в этом треугольнике, находим середину отрезка и заводим в цикл для рисования фигуры

int x = xa, y = ya;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}