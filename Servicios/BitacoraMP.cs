using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Servicios
{
    public class BitacoraMP
    {
        public void Agregar_entrada_bitacora(Bitacora Bt)
        {
            if (System.IO.File.Exists("c:/iadaBD/Bitacora_BD.xml") == false)
            {
                Crear_bitacora();
            }

            XDocument xmlBitacora = XDocument.Load("c:/iadaBD/Bitacora_BD.xml");

            xmlBitacora.Element("Bitacora_BD").Add(new XElement("Bitacora",
                                  new XElement("ID_usuario", Bt.ID_usuario),
                  new XElement("Nombre_usuario", Bt.Nombre_usuario),
                                  new XElement("Tipo_de_movimiento", Bt.Tipo_de_movimiento),
                  new XElement("Fecha", Bt.Fecha.ToString()),
                  new XElement("Nombre_de_archivo", Bt.Nombre_de_archivo),
                  new XElement("Ruta", Bt.Ruta)));
            xmlBitacora.Save("c:/iadaBD/Bitacora_BD.xml");

        }
        public List<Bitacora> Retornar_entradas_bitacora()
        {
            List<Bitacora> Lista_bitacora = new List<Bitacora>();

            if (System.IO.File.Exists("c:/iadaBD/Bitacora_BD.xml") == true)
            {
                var query =

                       from Bitacora in XElement.Load("c:/iadaBD/Bitacora_BD.xml").Elements("Bitacora")

                       select new Bitacora()
                       {
                           ID_usuario = Convert.ToUInt32(Bitacora.Element("ID_usuario").Value),
                           Nombre_usuario = Bitacora.Element("Nombre_usuario").Value,
                           Tipo_de_movimiento = (Bitacora.Element("Tipo_de_movimiento").Value),
                           Fecha = Convert.ToDateTime(Bitacora.Element("Fecha").Value),
                           Ruta = Bitacora.Element("Ruta").Value,
                           Nombre_de_archivo = Bitacora.Element("Nombre_de_archivo").Value,
                       };


                Lista_bitacora = query.ToList<Bitacora>();

            }
            return Lista_bitacora;

        }

        public void Crear_bitacora()
        {
            XmlTextWriter Lotestwr = new XmlTextWriter("c:/iadaBD/Bitacora_BD.xml", System.Text.Encoding.UTF8);
            Lotestwr.Formatting = Formatting.Indented;
            Lotestwr.Indentation = 2;
            Lotestwr.WriteStartDocument(true);
            Lotestwr.WriteStartElement("Bitacora_BD");
            Lotestwr.WriteEndElement();
            Lotestwr.WriteEndDocument();
            Lotestwr.Close();
        }

    }
}
