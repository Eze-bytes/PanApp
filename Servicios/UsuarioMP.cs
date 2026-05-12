using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace Servicios
{
    public class UsuarioMP
    {
        RolMP Rmp = new RolMP();
        Crear_BD BD = new Crear_BD();

        public List<Usuario> Mostrar_usuarios()
        {
            var query =

               from Usuario in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("Usuario")

               select new Usuario(Convert.ToString(Usuario.Element("Clave").Value))
               {
                   ID_usuario = (Convert.ToUInt32(Usuario.Element("ID_usuario").Value)),
                   Nombre = (Convert.ToString(Usuario.Element("Nombre").Value))
               };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();
            return usuario_consulta;
        }


        public List<Usuario> Mostrar_usuarios_roles()             ///descargo usuarios con sus roles
        {
            var query =

                from Usuario in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("Usuario")

                select new Usuario(Convert.ToString(Usuario.Element("Clave").Value))
                {

                    ID_usuario = (Convert.ToUInt32(Usuario.Element("ID_usuario").Value)),
                    Nombre = (Convert.ToString(Usuario.Element("Nombre").Value))

                };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();

            foreach (Usuario usu in usuario_consulta)
            {
                XmlDocument archivo = new XmlDocument();
                archivo.Load("c:/PanApp/PanApp_BD.xml");
                XmlNodeList lista_usuario = archivo.SelectNodes("BD/Usuario");
                XmlNodeList lista_rol = archivo.SelectNodes("BD/Rol");
                foreach (XmlNode nodo in lista_usuario)
                {
                    if (Convert.ToInt32(nodo.SelectSingleNode("ID_usuario").InnerText) == usu.ID_usuario)
                    {
                        foreach (XmlNode n in nodo.SelectNodes("Roles_de_usuario"))
                        {
                            Componente c = new Rol();
                            c.ID = Convert.ToString(n.SelectSingleNode("ID_rol").InnerText);

                            foreach (XmlNode nod in lista_rol)
                            {
                                if (nod.SelectSingleNode("ID_rol").InnerText == c.ID)

                                {
                                    c.Descripcion = nod.SelectSingleNode("Nombre_rol").InnerText;
                                    break;
                                }
                            }
                            usu.Agregar_roles(c);
                        }
                    }
                }

            }

            return usuario_consulta;
        }


        public void borrar_rol_de_usuario(Componente c, Usuario usu)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_usuario = archivo.SelectNodes("BD/Usuario");
            foreach (XmlNode nod in lista_usuario)
            {
                if (Convert.ToInt32(nod.SelectSingleNode("ID_usuario").InnerText) == usu.ID_usuario)
                {
                    foreach (XmlNode n in nod.SelectNodes("Roles_de_usuario"))
                    {

                        if (n.SelectSingleNode("ID_rol").InnerText == c.ID)
                        {
                            nod.RemoveChild(n);
                            break;
                        }
                    }
                    break;
                }

            }

            archivo.Save("c:/PanApp/PanApp_BD.xml");
        }


        public void Agregar_usuario(Usuario usu, bool admin)        // si admin=true crea el administrador
        {
            if (System.IO.File.Exists("c:/PanApp/PanApp_BD.xml") == false)

            { this.BD.Crear_nueva_BD("c:/PanApp/PanApp_BD.xml"); }

            XDocument xmlBD = XDocument.Load("c:/PanApp/PanApp_BD.xml");
            if (admin == true)
            {
                xmlBD.Element("BD").Add(new XElement("Usuario", new XElement("ID_usuario", usu.ID_usuario), new XElement("Nombre", usu.Nombre),
                    new XElement("Clave", usu.Obtener_pass()),

                    new XElement("Roles_de_usuario", new XElement("ID_rol", "admin"))

                    ));

            }
            else
            {
                xmlBD.Element("BD").Add(new XElement("Usuario", new XElement("ID_usuario", usu.ID_usuario), new XElement("Nombre", usu.Nombre),
                    new XElement("Clave", usu.Obtener_pass())));
            }
            xmlBD.Save("c:/PanApp/PanApp_BD.xml");

        }


        public bool Checkear_bd()
        {
            string routefolder = @"C:\PanApp";
                
            if (Directory.Exists(routefolder))           //si existe la carpeta
            {

                if (System.IO.File.Exists("c:/PanApp/PanApp_BD.xml") == false)
                {

                    return false;                       // no existe el archivo


                }
                else
                { return true; }

            }
            else                                     //se crea la carpeta sino existe

            {
                Directory.CreateDirectory(routefolder);   
                return false;                       // se creo la carpeta para la BD

            }




        }


        public bool Checkear_usuario(Usuario usu)     ///checkea si existe el ID
        {
            if (System.IO.File.Exists("c:/PanApp/PanApp_BD.xml") == false)

            {
                BD.Crear_nueva_BD("c:/PanApp/PanApp_BD.xml");
                return false;
            }


            var query =

                   from Usuario in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("Usuario")

                   select new Usuario
                   {
                       ID_usuario = (Convert.ToUInt32(Usuario.Element("ID_usuario").Value))
                   };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();
            if (usuario_consulta.Count == 0)
            { return false; }
            foreach (Usuario us in usuario_consulta)
            {
                if (us.ID_usuario == usu.ID_usuario)

                    return true;
            }
            return false;
        }


        public void Modificar_usuario(Usuario usu)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_usuario = archivo.SelectNodes("BD/Usuario");

            foreach (XmlNode nodo in lista_usuario)

            {
                if (nodo.SelectSingleNode("ID_usuario").InnerText == Convert.ToString(usu.ID_usuario))
                {
                    nodo.SelectSingleNode("Nombre").InnerText = usu.Nombre;
                    nodo.SelectSingleNode("Clave").InnerText = usu.Obtener_pass();
                    archivo.Save("c:/PanApp/PanApp_BD.xml");
                    break;
                }
            }
        }


        public void actualizar_roles_usuario(Usuario usu)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_usuario = archivo.SelectNodes("BD/Usuario");
            XmlNodeList lista_roles = archivo.SelectNodes("BD/Rol");
            foreach (XmlNode nodo in lista_usuario)

            {
                if (nodo.SelectSingleNode("ID_usuario").InnerText == Convert.ToString(usu.ID_usuario))
                {
                    foreach (XmlNode n in nodo.SelectNodes("Roles_de_usuario"))
                    {
                        nodo.RemoveChild(n);
                    }
                    foreach (Componente c in usu.Mostrar_lista())
                    {
                        XmlElement rol = archivo.CreateElement("Roles_de_usuario");
                        XmlElement id_rol = archivo.CreateElement("ID_rol");
                        id_rol.InnerText = c.ID;
                        rol.AppendChild(id_rol);
                        nodo.AppendChild(rol);
                    }
                }
            }
            archivo.Save("c:/PanApp/PanApp_BD.xml");
        }


        public void Eliminar_usuario(Usuario usu)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_nodos = archivo.SelectNodes("BD");

            foreach (XmlNode nodo in lista_nodos)
            {
                foreach (XmlNode n in nodo.SelectNodes("Usuario"))
                {
                    if (Convert.ToInt32(n.SelectSingleNode("ID_usuario").InnerText) == usu.ID_usuario)
                    {
                        nodo.RemoveChild(n);
                        break;
                    }
                }

            }
            archivo.Save("c:/PanApp/PanApp_BD.xml");
        }

        public void Descargar_permisos(Usuario usu)
        {

            XmlDocument archivo = new XmlDocument();
            archivo.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_usuario = archivo.SelectNodes("BD/Rol");

            foreach (Componente c in usu.Mostrar_lista())       ///c es cada rol
            {
                foreach (XmlNode nod in lista_usuario)
                {
                    if (c.ID == nod.SelectSingleNode("ID_rol").InnerText)
                    {
                        XmlNodeList detalle = nod.SelectNodes("Permiso_detalle");
                        if (detalle != null)
                        {
                            foreach (XmlNode n in detalle)
                            {
                                Componente per = new Permiso();
                                per.ID = n.SelectSingleNode("ID_permiso").InnerText;
                                c.Agregar(per);
                            }
                        }
                    }
                }
            }

        }

    }
}
