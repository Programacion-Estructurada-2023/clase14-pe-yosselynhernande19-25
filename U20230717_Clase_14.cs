﻿using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;
            do
            {
                Console.WriteLine("\nMenu de opciones:");
                Console.WriteLine("1. Sumar numeros pares hasta 75");
                Console.WriteLine("2. Encontrar el numero mayor de 9 numeros enteros");
                Console.WriteLine("3. Tabla de multiplicar de un numero con suma de 2");
                Console.WriteLine("4. Salir del programa");

            if (int.TryParse(Console.ReadLine(), out opciones))

                switch (opciones)
                   {
                        case 1:
                            int suma = 0;
                            for (int i = 2; i <= 75; i += 2)
                            {
                                suma += i;
                            }
                            Console.WriteLine("La suma de los numeros pares hasta 75 es: " + suma);
                            break;

                        case 2:
                            List<int> Numeros = new List<int> { 20, 5, 7, 55, 27, 65, 9, 11, 90 };
                            int mayor = Numeros[0];
                            foreach (int numero in Numeros)
                            {
                                if (numero > mayor)
                                {
                                    mayor = numero;
                                }
                            }
                            Console.WriteLine("\nEl numero mas mayor de la lista es> " + mayor);
                            break;

                        case 3:
                            Console.WriteLine("Ingresa un numero para generar la tabla de multiplicar: ");
                            int numero1= Convert.ToInt32(Console.ReadLine());
                            
                            for (int i =1 ; i <= 12; i++)
                            {
                                int multiplicacion = numero1 * i + 2;
                                Console.WriteLine($"{numero1} x {i} = {multiplicacion}");
                            }
                            break;

                        case 4:
                            break;
                        default:
                            Console.WriteLine("Opcion no valida, por favor, selecciona una opcion valida (1-4");
                            break;
                    }
                else
                {
                    Console.WriteLine("Entrada no valida. Ingresa un numero de (1-6).");
                }

            } while (opciones != 4);
        }
    }
}
