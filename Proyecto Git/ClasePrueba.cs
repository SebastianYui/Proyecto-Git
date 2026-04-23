using System;

class ClasePrueba
{
    static void Main()
    {
        int[] notas = { 3, 4, 2, 5, 1, 4, 3 };

        int suma = 0;
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];

            if (notas[i] >= 3)
                aprobados++;
            else
                reprobados++;
        }

        double promedio = (double)suma / notas.Length;

        Console.WriteLine($"Promedio: {promedio}");
        Console.WriteLine($"Aprobados: {aprobados}");
        Console.WriteLine($"Reprobados: {reprobados}");
    }
}