int a = 23;
int b = 11;
int c = 33;
int d = 6;
int e = 4;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);