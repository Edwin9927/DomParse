using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DomParse
{
    class DomParser
    {
        public void leer(string filename)
        {

            try
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(filename);

                XmlNodeList raiz = Doc.DocumentElement.SelectNodes("Juego");
                Console.WriteLine("Lista de juegos: \n");
                foreach (XmlNode nodo in raiz)
                {
                    Console.WriteLine("Nombre: " + nodo.ChildNodes.Item(0).InnerText);
                    Console.WriteLine("Genero: " + nodo.ChildNodes.Item(1).InnerText);
                    Console.WriteLine("Fecha: " + nodo.ChildNodes.Item(2).InnerText);
                    Console.WriteLine("Desarrollador:" + nodo.ChildNodes.Item(3).InnerText);
                    Console.WriteLine("Precio:" + nodo.ChildNodes.Item(4).InnerText);
                    Console.WriteLine("Unidades:" + nodo.ChildNodes.Item(5).InnerText);
                    Console.WriteLine("\n");
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Juegos con poco stock: \n");

                foreach (XmlNode nodo in raiz)
                {
                    if(int.Parse(nodo.ChildNodes.Item(5).InnerText) < 4)
                    {
                        Console.WriteLine("Nombre: " + nodo.ChildNodes.Item(0).InnerText);
                        Console.WriteLine("Genero: " + nodo.ChildNodes.Item(1).InnerText);
                        Console.WriteLine("Fecha: " + nodo.ChildNodes.Item(2).InnerText);
                        Console.WriteLine("Desarrollador:" + nodo.ChildNodes.Item(3).InnerText);
                        Console.WriteLine("Precio:" + nodo.ChildNodes.Item(4).InnerText);
                        Console.WriteLine("Unidades:" + nodo.ChildNodes.Item(5).InnerText);
                        Console.WriteLine("\n");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
