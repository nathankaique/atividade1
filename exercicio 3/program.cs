using System;

class Program
{
    static void Main()
    {
        int a = 7;
        int b = a - 6;

        int[] vetor = new int[6];

        // Preenchendo o vetor com valores de exemplo (opcional)
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = i * 2;  // Preenche o vetor com valores múltiplos de 2
        }

        while(b < a && b < vetor.Length)
        {
            Console.WriteLine($"vetor[{b}] = {vetor[b]}");
            b = b + 2;
        }
    }
}
