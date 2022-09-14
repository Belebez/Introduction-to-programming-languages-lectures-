// Решаем задачу с гирями, нужной найти гирю, которая больше всех весит

// вводим данные с помощью генератора случайных чисел

int a = new Random().Next(1, 1000);
Console.Write("Первая гиря весит - ");
Console.Write(a);
Console.Write(" кг");
Console.WriteLine();
int b = new Random().Next(1, 1000);
Console.Write("Вторая гиря весит - ");
Console.Write(b);
Console.Write(" кг");
Console.WriteLine();
int c = new Random().Next(1, 1000);
Console.Write("Третья гиря весит - ");
Console.Write(c);
Console.Write(" кг");
Console.WriteLine();
int d = new Random().Next(1, 1000);
Console.Write("Четвертая гиря весит - ");
Console.Write(d);
Console.Write(" кг");
Console.WriteLine();
int e = new Random().Next(1, 1000);
Console.Write("Пятая гиря весит - ");
Console.Write(e);
Console.Write(" кг");
Console.WriteLine();

//присвоем максимальное значение первой гири

int max = a;

// сравниваем все гири для нахождения максимального
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

//вывод макс гири

Console.Write("Самая большая гиря весит - ");
Console.Write(max);
Console.Write(" кг");
Console.WriteLine();