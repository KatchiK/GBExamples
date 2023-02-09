int a = 34;
int b = 49;
int c = 23;
int e = 15;
int d = 9;
int f = 15;

int max = a;

if (b>max) max = b;
if (c>max) max = c;
if (e>max) max = e;
if (d>max) max = d;
if (f>max) max = f;

Console.Write("Самое большое число: ");
Console.WriteLine(max);