using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    class ejercicio2
    {
        //Marco René Esquivel Juárez
        //23-oct-2019
        static string[] paises;
        public void ejer2()
        {
            int op, n;
            do
            {
                
                Console.WriteLine(" 1 - Agregar Paises.");
                Console.WriteLine(" 2 - Mostrar Paiseses.");
                Console.WriteLine(" 3 - Buscar Pais.");
                Console.WriteLine(" 4 - Salir.");
                
                op = validaciones("Seleccione una opccion: ", 1, 4);
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        StreamWriter archivo = new StreamWriter(@"C:\archivos\ejercicio2.txt", true);
                        Console.WriteLine("Cuantos paises desea agregar?");
                        n = validaciones("Maximo 10", 1, 10);
                        paises = new string[n];
                        for (int j = 0; j < paises.Length; j++)
                        {
                            Console.WriteLine("Pais N° {0}", j + 1);
                            paises[j] = Console.ReadLine();
                        }
                        string txt = string.Join(",", paises);
                        archivo.Write(txt);
                        archivo.Close();
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        StreamReader leerText = new StreamReader(@"C:\archivos\ejercicio2.txt");
                        string text;
                        text = leerText.ReadToEnd();
                        //Console.WriteLine(text);
                        paises = text.Split(',');
                        leerText.Close();
                        int i = 1;
                        Console.WriteLine("Lista de hombres almacenados: \n");
                        foreach (string item in paises)
                        {
                            Console.WriteLine("Nombre {0}: {1}", i, item);
                            i++;
                        }
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        StreamReader leerTxt = new StreamReader(@"C:\archivos\ejercicio2.txt");
                        string linea;
                        string buscar;
                        Console.WriteLine("Buscar Pais:");
                        buscar = Console.ReadLine();
                        i = 1;
                        do
                        {
                            linea = leerTxt.ReadLine();
                            if (linea != null)
                            {
                                foreach (string item in paises)
                                {
                                    if (item.Equals(buscar))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Nombre {0}: {1}", i, item);
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nombre {0}: {1}", i, item);
                                    }

                                    i++;
                                }
                            }
                        } while (linea != null);
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (op != 4);
        }
        //Validacio
        
        static int validaciones(string men, int lim1, int lim2)
        {
            bool esInt;
            int nOP;
            do
            {
                Console.WriteLine(men);
                esInt = int.TryParse(Console.ReadLine(), out nOP);
            } while (esInt == false || nOP < lim1 || nOP > lim2);
            return nOP;
        }
    }
}
