﻿using System;
using System.Collections.Generic;

namespace Frutas
{
    // Definición de la clase Fruta
    class Fruta
    {
        // Propiedades públicas para el nombre y el color de la fruta
        public string Nombre { get; set; }
        public string Color { get; set; }

        // Constructor para inicializar el nombre y el color de la fruta
        public Fruta(string nombre, string color)
        {
            Nombre = nombre;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Nombre} ({Color})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de frutas
            List<Fruta> frutas = new List<Fruta>();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n-----Menú-----");
                Console.WriteLine("1. Añadir fruta");
                Console.WriteLine("2. Eliminar fruta");
                Console.WriteLine("3. Mostrar lista de frutas");
                Console.WriteLine("4. Salir");

                Console.Write("\nElija una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre de la fruta: ");
                        string nombreFruta = Console.ReadLine();
                        Console.Write("Ingrese el color de la fruta: ");
                        string colorFruta = Console.ReadLine();
                        frutas.Add(new Fruta(nombreFruta, colorFruta));
                        Console.WriteLine("Fruta añadida con éxito.");
                        break;

                    case "2":
                        Console.Write("Ingrese el nombre de la fruta a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        Fruta frutaEliminar = frutas.Find(f => f.Nombre.Equals(nombreEliminar, StringComparison.OrdinalIgnoreCase));
                        if (frutaEliminar != null)
                        {
                            frutas.Remove(frutaEliminar);
                            Console.WriteLine("Fruta eliminada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("La fruta especificada no existe en la lista.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nLista de frutas:");
                        foreach (Fruta fruta in frutas)
                        {
                            Console.WriteLine(fruta);
                        }
                        break;

                    case "4":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }

            Console.WriteLine("Hasta luego, muchas gracias");
        }
    }
}
