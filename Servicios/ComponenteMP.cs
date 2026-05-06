using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Servicios
{
    public class ComponenteMP
    {
        public void Crear_tabla_permisos()
        {
            XDocument xmlBD = XDocument.Load("c:/PanApp/PanApp_BD.xml");

            xmlBD.Element("BD").Add(new XElement("Tabla_permisos", new XElement("Permiso_detalle",
                              new XElement("ID_permiso", "BK"),
                  new XElement("Descripcion", "Gestion de backups")),

            new XElement("Permiso_detalle",
                            new XElement("ID_permiso", "PP1"),
                new XElement("Descripcion", "Crear planilla de producción")),

            new XElement("Permiso_detalle",
                            new XElement("ID_permiso", "PP2"),
                new XElement("Descripcion", "Modificar planilla de producción")),

             new XElement("Permiso_detalle",
                            new XElement("ID_permiso", "PP3"),
                new XElement("Descripcion", "Imprimir planilla de producción")),


           new XElement("Permiso_detalle",
                              new XElement("ID_permiso", "PE1"),
                  new XElement("Descripcion", "Nuevo pedido")),

           new XElement("Permiso_detalle",
                              new XElement("ID_permiso", "PR"),
                  new XElement("Descripcion", "Modificar lista de precios")),

            new XElement("Permiso_detalle",
                 new XElement("ID_permiso", "PE2"),
     new XElement("Descripcion", "Editar pedidos")),

           new XElement("Permiso_detalle",
                             new XElement("ID_permiso", "PE3"),
                 new XElement("Descripcion", "Anular y confirmar pedidos")),


            new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "C1"),
                     new XElement("Descripcion", "Modificacion de clientes")),

            new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "L1"),
                     new XElement("Descripcion", "Crear lote nuevo")),

         new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "L2"),
                     new XElement("Descripcion", "Ver y modificar stock de lote")),

                     new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "U1"),
                     new XElement("Descripcion", "Ver y modificar usuarios")),

           new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "R1"),
                     new XElement("Descripcion", "Reporte de ventas semanal")),

           new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "F1"),
                     new XElement("Descripcion", "Facturar pedido")),

                new XElement("Permiso_detalle",
                            new XElement("ID_permiso", "A1"),
                new XElement("Descripcion", "Modificar permisos"))));

            xmlBD.Save("c:/PanApp/PanApp_BD.xml");

        }

        public List<Componente> Cargar_permisos()
        {
            {
                List<Componente> Lista_permisos = new List<Componente>();

                XmlDocument archivo = new XmlDocument();
                archivo.Load("c:/PanApp/PanApp_BD.xml");

                XmlElement Permisos = archivo.DocumentElement;
                XmlNode Tabla = archivo.SelectSingleNode("BD/Tabla_permisos");

                foreach (XmlNode nod in Tabla.ChildNodes)
                {
                    Permiso p = new Permiso();
                    p.Descripcion = nod.SelectSingleNode("Descripcion").InnerText;
                    p.ID = nod.SelectSingleNode("ID_permiso").InnerText;
                    Lista_permisos.Add(p);

                }

                return Lista_permisos;
            }
        }

    }
}
