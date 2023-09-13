/*Напишите программу вычисления функции Аккермана
 с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Ackermann(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0)
        return Ackermann(n - 1, 1);
    else
        return Ackermann(n - 1, Ackermann(n, m - 1));
}
Console.Write(Ackermann(1,2));

/*
}
   если n = 0
     вернуть m + 1
   иначе, если m = 0
     вернуть ack (n - 1, 1)
   еще
     вернуть ack(n - 1, ack (n, m - 1))*/
