// вводим данные для решения задачи с собакой(сколько раз пробежит собака до каждого человека на определенном расстоянии), используем генератор случайных чисел для ввода первичных данных.
Console.WriteLine("Вводные данные следующие: ");
int distance = new Random().Next(1000, 10001);
Console.WriteLine("Дистанция между двух друзей - " + distance + " км");
int first_friend_speed = new Random().Next(1, 6);
Console.WriteLine("Скорость первого друга - " + first_friend_speed + " км/ч");
int second_friend_speed = new Random().Next(1, 6);
Console.WriteLine("Скорость второго друга - " + second_friend_speed + " км/ч");
int dog_speed = new Random().Next(5, 35);
Console.WriteLine("Скорость собаки - " + dog_speed + " км/ч" );
int friend = new Random().Next(1, 3);
Console.WriteLine("Собака находится у " + friend + " друга");
int count = 0;
int time;

// создаем цикл для решения задачи

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (first_friend_speed + dog_speed); //находим за какое время собака и друг встретятся
        friend = 2;
        distance = distance - (second_friend_speed + first_friend_speed) * time; // уменьшаем расстояние которое приодолели участники за это время
        count++;
    }
    else
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 1;
        distance = distance - (second_friend_speed + first_friend_speed) * time;
        count++;
    }
}
Console.WriteLine("Собака успела пробежать до каждого друга - " + count + " раз");