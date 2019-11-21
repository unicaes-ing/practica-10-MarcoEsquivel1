using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    class ejercicio4
    {
        //Marco René Esquivel Juárez
        //23-oct-2019
        public void ejer4()
        {
            StreamReader archivo = new StreamReader(@"c:\archivos\ejercicio3.txt");
            string contra;
            contra = archivo.ReadLine();
            contra = contra.Remove(1, 1);
            contra = contra.Remove(2, 1);
            contra = contra.Replace("%", "a");
            contra = contra.Replace("/", "e");
            Console.WriteLine(contra);
            archivo.Close();
            Console.ReadKey();
        }
    }
}
