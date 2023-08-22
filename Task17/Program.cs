/*
Напиши программу, которая принимает на вход уоординаты точки (x,y), 
причем x и y не равно 0 и выдает номер четверти плоскости, в которой находистя эта точка
*/

Console.WriteLine("enter x and y ");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());
if (userX > 0 && userY > 0)
{
    Console.WriteLine($"{userX} и {userY} 1 четверть");
}
else if (userX < 0 && userY > 0)
{
    Console.WriteLine($"{userX} и {userY} 2 четверть");
}
else if (userX < 0 && userY < 0)
{
    Console.WriteLine($"{userX} и {userY} 3 четверть");
}
else
{
    Console.WriteLine($"{userX} и {userY} 4 четверть");
}