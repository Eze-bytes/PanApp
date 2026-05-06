using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Servicios

{
    public class Backup
    {
     
        public void Crear_backup(string path)
        {
            XmlDocument archivoBD = new XmlDocument();
            archivoBD.Load("c:/PanApp/PanApp_BD.xml");
            archivoBD.Save(path);
        }

        public void Restaurar_backup(string path)
        {
            XmlDocument archivoBD = new XmlDocument();
            archivoBD.Load(path);
            archivoBD.Save("c:/PanApp/PanApp_BD.xml");
        }
    }
}
