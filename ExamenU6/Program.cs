using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamenU6
{
    class Program
    {
        class Inventario
        {
            public void NuevoProducto()
            {
                StreamWriter sw = new StreamWriter("Inventario.txt", true);
                try
                {
                    Console.Clear();
                    //captura de datos
                    Console.Write("Ingrese el nombre del producto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese la descripción del producto: ");
                    string desc = Console.ReadLine();
                    Console.Write("Ingrese el precio del producto: ");
                    float precio = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad disponible del producto: ");
                    int cantidad = int.Parse(Console.ReadLine());
                    sw.WriteLine("");
                    sw.WriteLine("Nombre: " + nombre);
                    sw.WriteLine("Descripción: " + desc);
                    sw.WriteLine("Precio: "+ precio);
                    sw.WriteLine("Cantidad: " + cantidad);

                }
                catch (IOException e)
                {
                    Console.WriteLine("\nError: " + e.Message);
                    Console.WriteLine("\nRuta: " + e.StackTrace);
                }
                finally
                {
                    Console.Clear();
                    Console.WriteLine("Artículo agregado");
                    Console.Write("\n Presione <enter> para terminar la Escritura de Datos y regresar al menu ");
                    sw.Close();
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            public void LimpiarInventario()
            {
                Console.Clear();
                StreamWriter sw = new StreamWriter("Inventario.txt", false);
                Console.WriteLine("Limpieza hecha.");
                Console.Write("\n Presione <enter> para regresar al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            int opcion;
            Inventario inv = new Inventario();
            do
            {
                Console.WriteLine("---INVENTARIO AMAZON-----");
                Console.WriteLine();
                Console.WriteLine("1. Ingresar un nuevo producto");
                Console.WriteLine("2. Limpiar inventario");
                Console.WriteLine("3. Salida del programa");
                Console.Write("¿Qué opción desea? ");
                opcion = Int16.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        inv.NuevoProducto();
                        break;
                    case 2:
                        inv.LimpiarInventario();
                        break;
                    case 3:
                        Console.Write("\nPresione <ENTER> para Salir del Programa...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("\nEsa Opción no Existe !!, Presione <ENTER> para Continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 3);
        }
    }
}
