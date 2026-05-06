using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml;
using System.Xml.Linq;

namespace Mapper
{
    public class LoteMP
    {

        public void Crear_lote(Lote L)
        {

            XDocument xmlLotes = XDocument.Load("c:/PanApp/PanApp_BD.xml");

            xmlLotes.Element("BD").Add(new XElement("Lote",
                                  new XElement("Nro_lote", L.Nro_lote),
                  new XElement("Fecha_de_vencimiento", (L.Fecha_de_vencimiento).ToShortDateString())));
            xmlLotes.Save("c:/PanApp/PanApp_BD.xml");
            agregar_prod(L);
        }

        public bool Checkear_lotes()                               //checkea si hay lotes en la base
        {                                                          //false si no hay lotes o true si existen    

            {
                XDocument xmlLotes = XDocument.Load("c:/PanApp/PanApp_BD.xml");
                var xDoc = XDocument.Load("c:/PanApp/PanApp_BD.xml");
                int conteo = 0;
                conteo = xDoc.Descendants("Lote").Count();
                if (conteo > 0)
                { return true; }
                else
                { return false; }
            }

        }

        public List<Lote> Listado_de_lotes()          /// retorno una lista con todos los lotes de la BD
        {

            var query =

                        from Lote in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("Lote")

                        select new Lote
                        {
                            Nro_lote = Convert.ToInt32((Lote.Element("Nro_lote").Value)),
                            Fecha_de_vencimiento = Convert.ToDateTime(Lote.Element("Fecha_de_vencimiento").Value)
                        };


            List<Lote> Lista_lotes = query.ToList<Lote>();

            return Lista_lotes;
        }


        public void Detalle_de_lote(Lote L)         /// bajo de la BD el detalle al objeto lote 
        {

            var consulta_phc =

            from HAMBURGUESAS in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("HAMBURGUESAS")

            where Convert.ToInt32(HAMBURGUESAS.Element("Peso").Value) == 200 & Convert.ToInt32(HAMBURGUESAS.Element("Nro_lote").Value) == L.Nro_lote

            select new Pan_hamburguesa_comun
            {
                Nro_lote = Convert.ToInt32((HAMBURGUESAS.Element("Nro_lote").Value)),
                Unidades = Convert.ToUInt32((HAMBURGUESAS.Element("Unidades").Value))

            };

            if (consulta_phc.Count() == 1)
            { L.agregar_a_lote(consulta_phc.ElementAt(0)); }

            var consulta_phm =

           from HAMBURGUESAS in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("HAMBURGUESAS")

           where Convert.ToInt32(HAMBURGUESAS.Element("Peso").Value) == 320 & Convert.ToInt32(HAMBURGUESAS.Element("Nro_lote").Value) == L.Nro_lote

           select new Pan_hamburguesa_maxi
           {
               Nro_lote = Convert.ToInt32((HAMBURGUESAS.Element("Nro_lote").Value)),
               Unidades = Convert.ToUInt32((HAMBURGUESAS.Element("Unidades").Value))

           };

            if (consulta_phm.Count() == 1)
            { L.agregar_a_lote(consulta_phm.ElementAt(0)); }

            var consulta_plc =

           from LACTAL in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("LACTAL")

           where Convert.ToInt32(LACTAL.Element("Peso").Value) == 300 & Convert.ToInt32(LACTAL.Element("Nro_lote").Value) == L.Nro_lote

           select new Pan_lactal_chico
           {
               Nro_lote = Convert.ToInt32((LACTAL.Element("Nro_lote").Value)),
               Unidades = Convert.ToUInt32((LACTAL.Element("Unidades").Value))
           };

            if (consulta_plc.Count() == 1)
            { L.agregar_a_lote(consulta_plc.ElementAt(0)); }

            var consulta_plg =

           from LACTAL in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("LACTAL")

           where Convert.ToInt32(LACTAL.Element("Peso").Value) == 600 & Convert.ToInt32(LACTAL.Element("Nro_lote").Value) == L.Nro_lote

           select new Pan_lactal_grande
           {
               Nro_lote = Convert.ToInt32((LACTAL.Element("Nro_lote").Value)),
               Unidades = Convert.ToUInt32((LACTAL.Element("Unidades").Value))
           };

            if (consulta_plg.Count() == 1)
            { L.agregar_a_lote(consulta_plg.ElementAt(0)); }

            var consulta_ppc =

                 from PANCHOS in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("PANCHOS")

                 where Convert.ToInt32(PANCHOS.Element("Peso").Value) == 230 & Convert.ToInt32(PANCHOS.Element("Nro_lote").Value) == L.Nro_lote

                 select new Pan_pancho_chico
                 {
                     Nro_lote = Convert.ToInt32((PANCHOS.Element("Nro_lote").Value)),
                     Unidades = Convert.ToUInt32((PANCHOS.Element("Unidades").Value))
                 };

            if (consulta_ppc.Count() == 1)
            { L.agregar_a_lote(consulta_ppc.ElementAt(0)); }

            var consulta_ppm =

               from PANCHOS in XElement.Load("c:/PanApp/PanApp_BD.xml").Elements("PANCHOS")

               where Convert.ToInt32(PANCHOS.Element("Peso").Value) == 350 & Convert.ToInt32(PANCHOS.Element("Nro_lote").Value) == L.Nro_lote

               select new Pan_pancho_maxi
               {
                   Nro_lote = Convert.ToInt32((PANCHOS.Element("Nro_lote").Value)),
                   Unidades = Convert.ToUInt32((PANCHOS.Element("Unidades").Value))
               };

            if (consulta_ppm.Count() == 1)
            { L.agregar_a_lote(consulta_ppm.ElementAt(0)); }

        }

        public void agregar_a_lote_stock(List<Panificados> lista_panificados)
        {                                                            ///agrega productos a la bd de lote que no fueron cargados
            XDocument xmlStock = XDocument.Load("c:/PanApp/PanApp_BD.xml");        ///al crear el lote                                                                                                                 

            foreach (Panificados p in lista_panificados)
            {

                switch (p.Peso)
                {
                    case 200:
                        xmlStock.Element("BD").Add(new XElement("HAMBURGUESAS",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("c:/PanApp/PanApp_BD.xml");

                        break;

                    case 320:
                        xmlStock.Element("BD").Add(new XElement("HAMBURGUESAS",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("c:/PanApp/PanApp_BD.xml");
                        break;

                    case 300:
                        xmlStock.Element("BD").Add(new XElement("LACTAL",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("c:/PanApp/PanApp_BD.xml");
                        break;

                    case 600:
                        xmlStock.Element("BD").Add(new XElement("LACTAL",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("c:/PanApp/PanApp_BD.xml");
                        break;

                    case 230:
                        xmlStock.Element("BD").Add(new XElement("PANCHOS",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("c:/PanApp/PanApp_BD.xml");
                        break;

                    case 350:
                        xmlStock.Element("BD").Add(new XElement("PANCHOS",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("c:/PanApp/PanApp_BD.xml");
                        break;

                }
            }

        }

        public void Borrar_de_lote(Panificados p)
        {
            XElement x = XElement.Load("c:/PanApp/PanApp_BD.xml");

            switch (p.Peso)
            {

                case 200:
                    var consulta = x.Elements("HAMBURGUESAS").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta.Remove();

                    break;

                case 320:
                    var consulta2 = x.Elements("HAMBURGUESAS").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta2.Remove();
                    break;

                case 300:
                    var consulta3 = x.Elements("LACTAL").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta3.Remove();
                    break;
                case 600:
                    var consulta4 = x.Elements("LACTAL").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta4.Remove();
                    break;
                case 230:
                    var consulta5 = x.Elements("PANCHOS").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta5.Remove();
                    break;

                case 350:
                    var consulta6 = x.Elements("PANCHOS").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta6.Remove();
                    break;
            }

            x.Save("c:/PanApp/PanApp_BD.xml");

        }

        public bool Lote_del_dia(Lote L)       //retorna true si ya existe lote del dia sino false
        {

            if (System.IO.File.Exists("c:/PanApp/PanApp_BD.xml") == false)
            { return false; }
            else
            {
                XElement xmlLote = XElement.Load("c:/PanApp/PanApp_BD.xml");
                var consulta = xmlLote.Elements("Lote").Where(n => n.Element("Nro_lote").Value == Convert.ToString(L.Nro_lote));
                if (consulta.Count() == 1)
                { return true; }
                else
                { return false; }
            }


        }


        public void agregar_prod(Lote L)
        {

            if (L.retorna_Phc() != null)
            {
                XDocument xmlHamburguesas = XDocument.Load("c:/PanApp/PanApp_BD.xml");

                xmlHamburguesas.Element("BD").Add(new XElement("HAMBURGUESAS",
                                      new XElement("Nro_lote", L.Nro_lote),
                      new XElement("Unidades", L.retorna_Phc().Unidades),
                      new XElement("Peso", L.retorna_Phc().Peso)));
                xmlHamburguesas.Save("c:/PanApp/PanApp_BD.xml");

            }

            if (L.retorna_Pmm() != null)
            {
                XDocument xmlHamburguesas = XDocument.Load("c:/PanApp/PanApp_BD.xml");
                xmlHamburguesas.Element("BD").Add(new XElement("HAMBURGUESAS",
                      new XElement("Nro_lote", L.Nro_lote),
                new XElement("Unidades", L.retorna_Pmm().Unidades),
                new XElement("Peso", L.retorna_Pmm().Peso)));
                xmlHamburguesas.Save("c:/PanApp/PanApp_BD.xml");

            }

            if (L.retorna_Plc() != null)
            {
                XDocument xmlLactal = XDocument.Load("c:/PanApp/PanApp_BD.xml");
                xmlLactal.Element("BD").Add(new XElement("LACTAL",
                         new XElement("Nro_lote", L.Nro_lote),
         new XElement("Unidades", L.retorna_Plc().Unidades),
         new XElement("Peso", L.retorna_Plc().Peso)));
                xmlLactal.Save("c:/PanApp/PanApp_BD.xml");
            }

            if (L.retorna_Plg() != null)
            {

                XDocument xmlLactal = XDocument.Load("c:/PanApp/PanApp_BD.xml");
                xmlLactal.Element("BD").Add(new XElement("LACTAL",
                      new XElement("Nro_lote", L.Nro_lote),
      new XElement("Unidades", L.retorna_Plg().Unidades),
      new XElement("Peso", L.retorna_Plg().Peso)));
                xmlLactal.Save("c:/PanApp/PanApp_BD.xml");

            }

            if (L.retorna_Ppc() != null)
            {
                XDocument xmlPanchos = XDocument.Load("c:/PanApp/PanApp_BD.xml");
                xmlPanchos.Element("BD").Add(new XElement("PANCHOS",
                      new XElement("Nro_lote", L.Nro_lote),
      new XElement("Unidades", L.retorna_Ppc().Unidades),
      new XElement("Peso", L.retorna_Ppc().Peso)));
                xmlPanchos.Save("c:/PanApp/PanApp_BD.xml");
            }

            if (L.retorna_Ppm() != null)
            {
                XDocument xmlPanchos = XDocument.Load("c:/PanApp/PanApp_BD.xml");
                xmlPanchos.Element("BD").Add(new XElement("PANCHOS",
                      new XElement("Nro_lote", L.Nro_lote),
      new XElement("Unidades", L.retorna_Ppm().Unidades),
      new XElement("Peso", L.retorna_Ppm().Peso)));
                xmlPanchos.Save("c:/PanApp/PanApp_BD.xml");

            }
        }

        public void modificar_stock(List<Panificados> lista_panificados)
        {


            foreach (Panificados p in lista_panificados)
            {
                XmlDocument archivo = new XmlDocument();
                archivo.Load("c:/PanApp/PanApp_BD.xml");

                //XmlElement Stock = archivo.DocumentElement;



                if (p.Peso == 200 | p.Peso == 320)
                {

                    XmlNodeList lista_h = archivo.SelectNodes("BD/HAMBURGUESAS");
                    foreach (XmlNode nodo in lista_h)
                    {
                        if (nodo.SelectSingleNode("Nro_lote").InnerText == Convert.ToString(p.Nro_lote) & nodo.SelectSingleNode("Peso").InnerText == Convert.ToString(p.Peso))
                        {
                            nodo.SelectSingleNode("Unidades").InnerText = Convert.ToString(p.Unidades);
                            archivo.Save("c:/PanApp/PanApp_BD.xml");
                            break;
                        }
                    }
                }

                else
                {
                    if (p.Peso == 300 | p.Peso == 600)
                    {
                        XmlNodeList lista_l = archivo.SelectNodes("BD/LACTAL");
                        foreach (XmlNode nodo in lista_l)
                        {
                            if (nodo.SelectSingleNode("Nro_lote").InnerText == Convert.ToString(p.Nro_lote) & nodo.SelectSingleNode("Peso").InnerText == Convert.ToString(p.Peso))
                            {
                                nodo.SelectSingleNode("Unidades").InnerText = Convert.ToString(p.Unidades);
                                archivo.Save("c:/PanApp/PanApp_BD.xml");
                                break;
                            }
                        }
                    }
                    else
                    {
                        XmlNodeList lista_p = archivo.SelectNodes("BD/PANCHOS");
                        foreach (XmlNode nodo in lista_p)
                        {
                            if (nodo.SelectSingleNode("Nro_lote").InnerText == Convert.ToString(p.Nro_lote) & nodo.SelectSingleNode("Peso").InnerText == Convert.ToString(p.Peso))
                            {
                                nodo.SelectSingleNode("Unidades").InnerText = Convert.ToString(p.Unidades);
                                archivo.Save("c:/PanApp/PanApp_BD.xml");
                                break;
                            }
                        }
                    }
                }
            }

        }

    }
}
