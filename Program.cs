using System;

namespace Ej_2
{
    /*Programa que pide grados centígrados y los pasa a grados fahrenheit.

        La fórmula para pasar ºC a ºF es la siguiente => (0 °C × 9 / 5) + 32 = 32 °F
        El siguiente programa pide al usuario que ponga unos ºC (x).
        Posteriormente, el programa realizará la fórmula descrita y mostrará el resultado.*/

    class Program
    {
        static void Main(string[] args)
        {
            //Pide los ºC al usuario.
            Console.WriteLine("Escribe los grados centígrados (ºC) que quieras pasar a grados fahrenheit (ºF):");
            double gradosC = Double.Parse(Console.ReadLine());

            //Realiza la fórmula y muestra el resultado por pantalla.
            double gradosF = (gradosC * 9 / 5) + 32;
            Console.WriteLine($"\n{gradosC}ºC son {gradosF}ºF");

            Console.ReadKey();
        }
    }
}
