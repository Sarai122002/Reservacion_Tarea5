using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reservacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir la ruta del archivo
            string path = (@"C:\Reservacion\archivo.text");


            using (StreamWriter archivo = File.AppendText(path))
            {
                //contenido del archivo
                archivo.WriteLine("COMPRA EN LINEA");
                //archivo.Close();//cierra el archivo creado
            }
            Console.ReadKey();
        }



    }
}

  