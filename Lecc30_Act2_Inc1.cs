using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lecc 30 - Act2 - Inciso 1");

        int[] edades = new int[7];
        int mayores = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Ingrese la edad " + (i + 1) + ": ");
            edades[i] = Convert.ToInt32(Console.ReadLine());

            if (edades[i] >= 18)
            {
                mayores++;
            }
        }

        Console.WriteLine("La cantidad de personas mayores de edad es: " + mayores);
    }
}
