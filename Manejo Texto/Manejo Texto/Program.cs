using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_Texto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string line;

            try
            {
                string fileName = "D:\\Sample.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                writer.WriteLine(nombre);
                writer.Close();

                //Leer
                //Pase the file path and file name to the SttreamReader constructor
                StreamReader sr = new StreamReader("D:\\Sample.txt");
                //
                //read the first line text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
               
                while (line != null) 
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Error");
            }
               
            
        }
    }
}
