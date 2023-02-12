//Находим максимальное из 9 чисел с помощью функций(методов)


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 11;
int c1 = 1;
int a2 = 546;
int b2 = 41;
int c2 = 91;
int a3 = 51;
int b3 = 73;
int c3 = 6;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int maxMax = Max(max1, max2, max3);

Console.Write("Самое большое число это: ");
Console.Write(maxMax);
