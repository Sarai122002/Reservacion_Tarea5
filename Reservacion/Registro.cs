using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reservacion
{
    class Registro
    {
        //Sistema de reservacion a practica, el cual permite registrase o reservar practica
        //cambiar o actualizar el dia inscrita a practica
        // Eliminar registro o reservacion 
        static void Main()
            {
                bool showMenu = true;

                while (showMenu)
                {
                    showMenu = Menu(); 
                }
                Console.ReadKey();
            }

            private static bool Menu()
            {
       
                Console.WriteLine("REGISTRO A PRACTICAS PRESENCIALES ");
                Console.WriteLine("                                    ");
                Console.WriteLine("Seleccion la operación a realizar: ");
                Console.WriteLine("1. Reservar practica");
                Console.WriteLine("2. Cambiar dia de practica");
                Console.WriteLine("3. Eliminar reservacion a asistencia a practica");
                Console.WriteLine("4. Mostrar listado de estudiantes registrados a practica");
                Console.WriteLine("5. Salir");
                Console.Write("\nOpcion: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        registro(); 
                        return true;
                    case "2":
                        
                        return true;
                    case "3":
                      
                        return true;
                    case "4":
                        //mostrar el contenido del archivo
                        Console.WriteLine("LISTADO DE ESTUDIANTES");
                        foreach (KeyValuePair<object, object> data in readFile())
                        {
                            Console.WriteLine("{0}: {1}", data.Key, data.Value);
                        }
                        Console.ReadKey();
                        return true;
                    case "5":
                        return false;
                    default:
                        return false;
                }
            }

            private static string getPath()
            {
                string path = (@"C:\compra_en_linea\archivo.text");
                return path;
            }

            private static void registro()
            {
                Console.WriteLine("DATOS DEL ESTUDIANTE");
                Console.Write("Nombre Completo: ");
                string fullname = Console.ReadLine();
                Console.Write("Dia a asistir, Martes/Jueves: ");
                string fulllname = Console.ReadLine();

                if (search(fullname))
                {
                    Console.WriteLine("El nombre ya esta registrado, ingrese otro");
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(getPath()))
                    {
                        sw.WriteLine("{0}; {1}", fullname, fulllname);
                        sw.Close();
                    }
                }

            }

            private static Dictionary<object, object> readFile()
            {

                Dictionary<object, object> listData = new Dictionary<object, object>();

                using (var reader = new StreamReader(getPath()))
                {
                    string lines;

                    while ((lines = reader.ReadLine()) != null) 
                    {
                        string[] keyvalue = lines.Split(';');
                        if (keyvalue.Length == 2)
                        {
                            listData.Add(keyvalue[0], keyvalue[1]);
                        }
                    }

                }

   
                return listData;
            }
    }
}






