using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lecc30_Act2_Inc2_AndrésPérezIVC-28");

        int[] numeros = new int[8];
        int mayor = 0;
        int posicion = 0;

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            if (i == 0)
            {
                mayor = numeros[i];
                posicion = i;
            }
            else if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posicion = i;
            }
        }

        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("Se encuentra en la posición: " + (posicion + 1));
    }
}
