internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DATOS ACADEMICOS\nNombre: Andrés Pérez"+
            "\nGrado: IV C"+
            "\nClave: 28");

        //Crear e inicializar el arreglo
        int[] edadPersonas = new int[7];
        int cantidadPersonasMayores = 0;
        int cantidadPersonasmenores = 0;
        int i ;
        //Llenar arreglo 
        for ( i = 0; i<edadPersonas.Length;i++)
        {
            Console.Write("Ingrese la edad de la persona "+(i+1)+":");
            edadPersonas[i] = Convert.ToInt32(Console.ReadLine());

            if (edadPersonas[i] >= 18)
            {
                cantidadPersonasMayores++;
            }
            if (edadPersonas[i] < 18)
            {
                cantidadPersonasmenores++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de personas mayores de edad: "+
            cantidadPersonasMayores);
        Console.WriteLine("Cantidad de personas menores de edad: " +
            cantidadPersonasmenores);
        Console.WriteLine("Cantidad de personas en Total: " +i);
    }
}
