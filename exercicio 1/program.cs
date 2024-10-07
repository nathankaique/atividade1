using System;

int a = 10;
int b = 20;
int c = (a + b) / 2;
c = c - 40;

int[] v = new int[4];
v[3] = a + b + c;

for (int i = 0; i < 4; i++) {
    if (v[i] == 5) {
        Console.WriteLine($"o vetor [{i}] é 5; verdadeiro");
    } else {
        Console.WriteLine($"o vetor [{i}] não é 5; falso");
    }
}
