using System;

namespace TABLA_DE_MULTIPLICAR_CON_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, I, RESUL;
            string linea;

            Console.Write("DIGITE UN NÚMERO: ");
            linea = Console.ReadLine();

            // Convierte la entrada del usuario a un número entero
            NUM = int.Parse(linea);

            I = 1;
            while (I <= 12)
            {
                RESUL = NUM * I;
                Console.WriteLine($"{NUM} * {I} = {RESUL}");
                I = I + 1;
            }

            Console.Write("Pulse una tecla para salir...");
            Console.ReadLine();
        }
    }
}