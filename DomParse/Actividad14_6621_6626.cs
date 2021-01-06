using System;
using System.IO;
using System.Xml;

namespace DomParse
{
    class Actividad14_6621_6626
    {
        private const String filename = "../../../Store.xml";//Path del archivo XML
        static void Main(string[] args)
        {
            Console.WriteLine("Actividad 14\n\tEdwin Manzano   6626\n\tEstalin Morocho 6621\n");
            DomParser objDom = new DomParser();
            objDom.leer(filename);
            Console.ReadLine();

        }
    }
}
