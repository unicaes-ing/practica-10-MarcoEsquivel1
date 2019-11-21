using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //23-oct-2019
        public void ejer1()
        {
            string nombre;
            int op;
            StreamWriter archivo = new StreamWriter(@"c:\archivos\ejercicio1.txt", true);
            archivo.Close();
            do
            {
                Console.Clear();
                Console.WriteLine("1- Agregar pais");
                Console.WriteLine("2- Mostrar paises");
                Console.WriteLine("3- Buscar pais");
                Console.WriteLine("4- Salir");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del pais");
                        archivo = new StreamWriter(@"c:\archivos\ejercicio1.txt", true);
                        nombre = Console.ReadLine();
                        archivo.WriteLine(nombre);
                        archivo.Close();
                        Console.WriteLine("Pais agregado, <ENTER> para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        StreamReader leerArchivo = new StreamReader(@"c:\archivos\ejercicio1.txt");
                        nombre = null;
                        do
                        {
                            nombre = leerArchivo.ReadLine();
                            if (nombre != null)
                            {
                                Console.WriteLine("Nombre: {0}", nombre.ToUpper());
                            }
                        } while (nombre != null);
                        archivo.Close();
                        Console.WriteLine("<ENTER> para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        string buscar;
                        Console.WriteLine("Ingrese el pais que desea buscar");
                        buscar = Console.ReadLine();
                        buscar = buscar.ToUpper();
                        leerArchivo = new StreamReader(@"c:\archivos\ejercicio1.txt");
                        nombre = null;
                        do
                        {
                            nombre = leerArchivo.ReadLine();
                            if (nombre != null)
                            {
                                nombre = nombre.ToUpper();
                                if (nombre == buscar)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Nombre: {0}", nombre);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.WriteLine("Nombre: {0}", nombre.ToUpper());
                                }
                            }
                        } while (nombre != null);
                        archivo.Close();
                        Console.WriteLine("<ENTER> para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (op != 4);
        }
    }
}
