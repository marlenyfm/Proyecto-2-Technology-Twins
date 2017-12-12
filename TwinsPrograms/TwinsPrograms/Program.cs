using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string linea;
            Console.Write("Tabla de multiplicar \n ");
            Console.Write(" \n");
            Console.WriteLine("Realizado por: \n ");
            Console.WriteLine("Grupo Technology Twins \n");
            Console.WriteLine("Sección 0463 \n");
            Console.WriteLine("Arianny Cadena          16-siit-1-008");
            Console.WriteLine("Marleny Ferreira        16-siit-1-009 \n");
            Console.WriteLine("Este Programa muestra la tabla de multiplicar de un numero ingresado por el teclado del 1 al 12, ademas de mostrar si el numero ingresado es par o impar \n ");
            Console.Write("Ingrese Mutiplicador: ");

            linea = Console.ReadLine();
            n = int.Parse(linea);

            if (linea != String.Empty)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("El numero " + n + " es par: \n");
                }
                else
                {
                    Console.WriteLine("El numero " + n + " es impar: \n");

                }

                for (int i = 1; i < 13; i++)
                {
                    Console.Write(i + " x " + n + " = " + i * n + "\n");
                }

            }
      
        
       
         

            Console.ReadKey();
        }
    }
}
