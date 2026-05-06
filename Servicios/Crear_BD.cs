using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Servicios
{
    public class Crear_BD
    {
        public void Crear_nueva_BD(string path)
        {
            string carpeta = @"C:\iadaBD";
            
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }


            XmlTextWriter Lotestwr = new XmlTextWriter(path, System.Text.Encoding.UTF8);
            Lotestwr.Formatting = Formatting.Indented;
            Lotestwr.Indentation = 2;
            Lotestwr.WriteStartDocument(true);
            Lotestwr.WriteStartElement("BD");
            Lotestwr.WriteEndElement();
            Lotestwr.WriteEndDocument();
            Lotestwr.Close();

        }

    }
}
