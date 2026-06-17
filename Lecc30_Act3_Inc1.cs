using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lecc30_Act3_Inc1_AndresPerezIVC-28");

        int[] numeros = new int[15];
        bool hayRepetido = false;

        for (int i = 0; i < 15; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Verificar repetidos
        for (int i = 0; i < 14; i++)
        {
            for (int j = i + 1; j < 15; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    hayRepetido = true;
                }
            }
        }

        // Resultado
        if (hayRepetido)
        {
            Console.WriteLine("Sí existe al menos un número repetido.");
        }
        else
        {
            Console.WriteLine("No existe ningún número repetido.");
        }
    }
}
