// Задача с гирями. Нахождение самой тяжелой из пяти
int a = 11;
int b = 2;
int c = 7;
int d = 8;
int e = 3;
int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("Максимальный вес - ");
Console.WriteLine(max);
