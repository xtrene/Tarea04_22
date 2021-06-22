using System;

namespace Tarea04_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "12345";
            int intentos = 0;
            const int limiteIntentos = 3;
            string entrada = "";

            while (intentos < limiteIntentos && entrada != pass)
            {
                Console.Write("Introduce la contraseña (intento {0}/{1}): ", intentos+1, limiteIntentos);
                entrada= Console.ReadLine();
                if (entrada == pass)
                {
                    Console.WriteLine("ENHORABUENA !!! Contraseña correcta.");

                }
                else
                {
                    Console.WriteLine("¡¡¡ ERROR !!! Contraseña incorrecta.");
                }
                intentos++;

            }



            Console.WriteLine("FIN del programa.");
            Console.ReadKey();

        }
    }
}
