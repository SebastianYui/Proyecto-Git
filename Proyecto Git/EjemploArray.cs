using System;

class EjemploArray
{
    static void Main()
    {
        string[] nombres = { "Ana", "Luis", "Carlos", "Maria" };
        string buscado = "Carlos";

        bool encontrado = false;

        foreach (string nombre in nombres)
        {
            if (nombre == buscado)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
            Console.WriteLine("Elemento encontrado");
        else
            Console.WriteLine("Elemento no encontrado");
    }
}