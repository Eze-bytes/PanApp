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
            XDocument xmlBD = XDocument.Load("IADA_BD.xml");

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                              new XElement("ID_permiso", "BK"),
                  new XElement("Descripcion", "Gestion de backups")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                            new XElement("ID_permiso", "RS"),
                new XElement("Descripcion", "Reporte de stock")));


            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                              new XElement("ID_permiso", "PE1"),
                  new XElement("Descripcion", "Nuevo pedido")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                              new XElement("ID_permiso", "PR"),
                  new XElement("Descripcion", "Modificar lista de precios")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                 new XElement("ID_permiso", "PE2"),
     new XElement("Descripcion", "Editar pedidos")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                             new XElement("ID_permiso", "PE3"),
                 new XElement("Descripcion", "Anular y confirmar pedidos")));


            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "C1"),
                     new XElement("Descripcion", "Modificacion de clientes")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "L1"),
                     new XElement("Descripcion", "Crear lote nuevo")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "L2"),
                     new XElement("Descripcion", "Ver y modificar stock de lote")));

                     xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "U1"),
                     new XElement("Descripcion", "Ver y modificar usuarios")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "R1"),
                     new XElement("Descripcion", "Reporte de ventas semanal")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "F1"),
                     new XElement("Descripcion", "Facturar pedido")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                            new XElement("ID_permiso", "A1"),
                new XElement("Descripcion", "Modificar permisos")));

            xmlBD.Save("IADA_BD.xml");

        }

        public List<Componente> Cargar_permisos()
        {

            {
                var query =

                       from Permiso_detalle in XElement.Load("IADA_BD.xml").Elements("Permiso_detalle")

                       select new Permiso(Convert.ToString(Permiso_detalle.Element("Descripcion").Value), Convert.ToString(Permiso_detalle.Element("ID_permiso").Value))
                       {

                       };

                List<Componente> Lista_permisos = query.ToList<Componente>();
                return Lista_permisos;
            }
        }





    }
}
