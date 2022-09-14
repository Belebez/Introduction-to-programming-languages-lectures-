//задаем значиния 2 переменных, с помощью генератора случайного числа

int number_A = new Random().Next(1, 10); // диапазон случайного числа от 1 до 9 включительно
Console.Write("Первое число равно - ");
Console.Write(number_A);
Console.WriteLine();
int number_B = new Random().Next(1, 10);
Console.Write("Второе число равно - ");
Console.Write(number_B);
Console.WriteLine();

//ищем их сумму

int result = number_A + number_B;

//вывод суммы

Console.Write("Сумма 2 чисел равна - ");
Console.Write(result);