using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml;
using System.Xml.Linq;

namespace Servicios
{
    public class RolMP
    {
        public void Nuevo_rol(Componente c)
        {
            XDocument xmlrol = XDocument.Load("c:/PanApp/PanApp_BD.xml");

            {
                xmlrol.Element("BD").Add(new XElement("Rol",
                   new XElement("ID_rol", c.ID),
                   new XElement("Nombre_rol", c.Descripcion)));
            }

            xmlrol.Save("c:/PanApp/PanApp_BD.xml");

        }


        public void Actualizar_permisos(Componente c)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");

            XmlNodeList lista_roles = archivo.SelectNodes("BD/Rol");
            foreach (XmlNode nodo in lista_roles)
            {
                if (nodo.SelectSingleNode("Nombre_rol").InnerText == Convert.ToString(c.Descripcion))
                {
                    foreach (XmlNode n in nodo.SelectNodes("Permiso_detalle"))
                    {
                        nodo.RemoveChild(n);

                    }
                    foreach (Componente co in c.obtener_lista())
                    {
                        XmlElement permiso = archivo.CreateElement("Permiso_detalle");
                        XmlElement id_permiso = archivo.CreateElement("ID_permiso");
                        id_permiso.InnerText = co.Obtener_ID();
                        permiso.AppendChild(id_permiso);
                        nodo.AppendChild(permiso);
                    }

                    break;
                }
            }

            archivo.Save("c:/PanApp/PanApp_BD.xml");
        }

        public void Grabar_permisos_admin()
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_permisos = archivo.SelectNodes("BD/Tabla_permisos/Permiso_detalle");

            XmlNodeList lista_roles = archivo.SelectNodes("BD/Rol");

            foreach (XmlNode nod in lista_roles)
            {
                if (nod.SelectSingleNode("ID_rol").InnerText == "admin")
                {
                    foreach (XmlNode n in lista_permisos)
                    {
                        XmlElement detalle = archivo.CreateElement("Permiso_detalle");
                        XmlElement id_permiso = archivo.CreateElement("ID_permiso");
                        id_permiso.InnerText = n.SelectSingleNode("ID_permiso").InnerText;
                        detalle.AppendChild(id_permiso);
                        nod.AppendChild(detalle);
                    }

                    break;
                }
            }

            archivo.Save("c:/PanApp/PanApp_BD.xml");
        }


        public void Borrar_rol(Componente c)
        {

            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_roles = archivo.SelectNodes("BD/Rol");
            XmlNodeList lista_usuarios = archivo.SelectNodes("BD/Usuario");
            foreach (XmlNode nodo in lista_roles)
            {
                if (nodo.SelectSingleNode("ID_rol").InnerText == c.ID)
                {
                    archivo.DocumentElement.RemoveChild(nodo);
                    break;
                }
            }

            foreach (XmlNode nod in lista_usuarios)
            {
                foreach (XmlNode n in nod.SelectNodes("Roles_de_usuario"))
                {
                    if (n.SelectSingleNode("ID_rol") != null)
                    {
                        if (n.SelectSingleNode("ID_rol").InnerText == c.ID)
                        {
                            nod.RemoveChild(n);
                            break;
                        }
                    }
                }

            }
            archivo.Save("c:/PanApp/PanApp_BD.xml");
        }

        public void Agregar_permiso(Componente C)
        {

            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_roles = archivo.SelectNodes("BD/Rol");

            foreach (XmlNode nodo in lista_roles)

            {
                if (nodo.SelectSingleNode("Nombre_rol").InnerText == Convert.ToString(C.Descripcion))
                {

                    foreach (Componente Co in C.obtener_lista())
                    {
                        XmlElement permiso = archivo.CreateElement("Permiso_detalle");
                        XmlElement id_permiso = archivo.CreateElement("ID_permiso");
                        XmlElement desc_permiso = archivo.CreateElement("Descripcion");
                        id_permiso.InnerText = Co.Obtener_ID();
                        desc_permiso.InnerText = Co.Descripcion;
                        permiso.AppendChild(id_permiso);
                        permiso.AppendChild(desc_permiso);
                        nodo.AppendChild(permiso);

                    }
                    break;

                }
            }
            archivo.Save("c:/PanApp/PanApp_BD.xml");

        }

        public void Modificar_nombre_rol(string nuevo, string pID)         ///modifica nombre de rol en listado
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_roles = archivo.SelectNodes("BD/Rol");

            foreach (XmlNode nod in lista_roles)
            {
                if (nod.SelectSingleNode("ID_rol").InnerText == pID)
                {
                    nod.SelectSingleNode("Nombre_rol").InnerText = nuevo;
                    break;
                }

            }
            archivo.Save("c:/PanApp/PanApp_BD.xml");
        }


        public List<Componente> Roles_permisos_descargar()
        {
            List<Componente> lista_todo = new List<Componente>();

            var query =                                        ///roles

                      from Roles in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("Rol")

                      select new Rol(Convert.ToString(Roles.Element("Nombre_rol").Value))
                      {
                          ID = Roles.Element("ID_rol").Value
                      };


            lista_todo = query.ToList<Componente>();

            XmlDocument xmlpermisos = new XmlDocument();
            xmlpermisos.Load("c:/PanApp/PanApp_BD.xml");
            ///permisos
            XmlNodeList lista_permisos = xmlpermisos.SelectNodes("BD/Rol");
            XmlNodeList lista_permisos_detalle = xmlpermisos.SelectNodes("BD/Tabla_permisos/Permiso_detalle");
            foreach (Componente c in lista_todo)
            {

                foreach (XmlNode nod in lista_permisos)
                {
                    if (c.Descripcion == Convert.ToString(nod.SelectSingleNode("Nombre_rol").InnerText))
                    {
                        foreach (XmlNode n in nod.SelectNodes("Permiso_detalle"))
                        {
                            Componente co = new Permiso(null, Convert.ToString(n.SelectSingleNode("ID_permiso").InnerText));
                            c.Agregar(co);

                        }
                    }
                }

            }

            foreach (Componente c in lista_todo)
            {
                foreach (Componente co in c.obtener_lista())
                {
                    foreach (XmlNode n in lista_permisos_detalle)
                    {
                        if (n.SelectSingleNode("ID_permiso").InnerText == co.Obtener_ID())
                        {
                            co.Descripcion = n.SelectSingleNode("Descripcion").InnerText;
                        }
                    }

                }
            }
            return lista_todo;
        }

        public string Buscar_id_rol(string pDesc)
        {
            string ID = null;
            XmlDocument xmlrol = new XmlDocument();
            xmlrol.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_roles = xmlrol.SelectNodes("BD/Rol");

            foreach (XmlNode n in lista_roles)
            {
                if (Convert.ToString(n.SelectSingleNode("Nombre_rol").InnerText) == pDesc)
                {
                    ID = Convert.ToString(n.SelectSingleNode("ID_rol").InnerText);
                    break;
                }

            }

            return ID;

        }

    }
}