﻿int a = 10;
int b = 8;
int c = 6;
int d = 2;
int e = 4;
int max = a;
if (b > max) {
    max = b;
}

if (c > max) {
    max = c;
}

if (d > max) {
    max = d;
}

if (e > max) {
    max = e;
}
Console.WriteLine("The maximum value is: " + max);