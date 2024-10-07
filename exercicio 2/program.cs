using System;

class Program
{
    static void Main()
    {
        int a = 2;
        int[] vetor = new int[5];

        // Inicializando o vetor para ter alguns valores
        vetor[0] = 3;   // Exemplo de inicialização para todos os elementos
        vetor[1] = 4;
        vetor[2] = 5;
        vetor[3] = 6;
        vetor[4] = 7;

        for (int i = 0; i < vetor.Length; i++)
        {
            // Se o valor do vetor for igual a 5, realiza a operação
            if (vetor[i] == 5)
            {
                vetor[i] = 10 * a;
                a += 1;
            }

            Console.WriteLine($"vetor[{i}] = {vetor[i]}");
        }
    }
}
