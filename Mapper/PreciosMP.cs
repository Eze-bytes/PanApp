using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;

namespace Mapper
{
    public class PreciosMP
    {
        public void Grabar_lista_precios(Lista_precios Pr)
        {
            XDocument xmlBD = XDocument.Load("c:/PanApp/PanApp_BD.xml");


            xmlBD.Element("BD").Add(new XElement("Precios",
                                       new XElement("Fecha_de_actualizacion", Pr.Fecha_de_ultima_actualizacion.ToShortDateString()),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PHC.ID_producto),
                                       new XElement("Precio", Pr.PHC.Leer_precio().ToString())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PHM.ID_producto),
                                       new XElement("Precio", Pr.PHM.Leer_precio().ToString())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PLC.ID_producto),
                                       new XElement("Precio", Pr.PLC.Leer_precio().ToString())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PLG.ID_producto),
                                       new XElement("Precio", Pr.PLG.Leer_precio().ToString())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PPC.ID_producto),
                                       new XElement("Precio", Pr.PPC.Leer_precio().ToString())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PPM.ID_producto),
                                       new XElement("Precio", Pr.PPM.Leer_precio().ToString()))));

            xmlBD.Save("c:/PanApp/PanApp_BD.xml");

        }

        public bool Checkear_existencia_precios()
        {
            {

                XDocument xmlBD = XDocument.Load("c:/PanApp/PanApp_BD.xml");
                var xDoc = XDocument.Load("c:/PanApp/PanApp_BD.xml");
                int conteo = 0;
                conteo = xDoc.Descendants("Precios").Count();
                if (conteo == 1)
                { return true; }
                else
                { return false; }

            }
        }

        public void Asignar_precios(List<Panificados> lista_panificados)
        {
            Lista_precios Pr = Recuperar_lista_precios();
            foreach (Panificados p in lista_panificados)
            {

                foreach (Panificados prec in Pr.retornar_p_precios())
                {
                    if(p.GetType()==prec.GetType())
                    { p.Grabar_precio(prec.Leer_precio()); }


                }

            }




        }





        public void Modificar_lista_precios(Lista_precios Pr, bool mod)
        {

            if (mod == true)                          //true modifica lista, false nueva lista
            {
                XmlDocument xmlBD = new XmlDocument();
                xmlBD.Load("c:/PanApp/PanApp_BD.xml");

                XmlElement Precios = xmlBD.DocumentElement;
                XmlNodeList Lista_pedidos = xmlBD.SelectNodes("BD/Precios");

                foreach (XmlNode nodo in Lista_pedidos)
                {
                    {
                        Precios.RemoveChild(nodo);
                        xmlBD.Save("c:/PanApp/PanApp_BD.xml");
                        break;
                    }
                }

                Grabar_lista_precios(Pr);


            }
            else { Grabar_lista_precios(Pr); }

        }

        public Lista_precios Recuperar_lista_precios()
        {
            Lista_precios Pr = new Lista_precios();
            XmlDocument xmlprecios = new XmlDocument();
            xmlprecios.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_precio = xmlprecios.SelectNodes("BD/Precios");

            foreach (XmlNode nodo in lista_precio)
            {
                Pr.Fecha_de_ultima_actualizacion = Convert.ToDateTime(nodo.SelectSingleNode("Fecha_de_actualizacion").InnerText);
                foreach (XmlNode nodoprod in nodo.SelectNodes("Detalle_producto"))
                {

                    switch (nodoprod.SelectSingleNode("ID_producto").InnerText)
                    {
                        case "PHC":
                            Pan_hamburguesa_comun PHC = new Pan_hamburguesa_comun();
                            PHC.Grabar_precio(decimal.Parse(nodoprod.SelectSingleNode("Precio").InnerText, CultureInfo.CreateSpecificCulture("es-AR")));
                            Pr.PHC = PHC;
                            break;

                        case "PHM":
                            Pan_hamburguesa_maxi PHM = new Pan_hamburguesa_maxi();
                            PHM.Grabar_precio(decimal.Parse(nodoprod.SelectSingleNode("Precio").InnerText, CultureInfo.CreateSpecificCulture("es-AR")));
                            Pr.PHM = PHM;
                            break;
                        case "PLC":
                            Pan_lactal_chico PLC = new Pan_lactal_chico();
                            PLC.Grabar_precio(decimal.Parse(nodoprod.SelectSingleNode("Precio").InnerText, CultureInfo.CreateSpecificCulture("es-AR")));
                            Pr.PLC = PLC;
                            break;

                        case "PLG":
                            Pan_lactal_grande PLG = new Pan_lactal_grande();
                            PLG.Grabar_precio(decimal.Parse(nodoprod.SelectSingleNode("Precio").InnerText, CultureInfo.CreateSpecificCulture("es-AR")));
                            Pr.PLG = PLG;
                            break;
                        case "PPC":
                            Pan_pancho_chico PPC = new Pan_pancho_chico();
                            PPC.Grabar_precio(decimal.Parse(nodoprod.SelectSingleNode("Precio").InnerText, CultureInfo.CreateSpecificCulture("es-AR")));
                            Pr.PPC = PPC;
                            break;

                        case "PPM":
                            Pan_pancho_maxi PPM = new Pan_pancho_maxi();
                            PPM.Grabar_precio(decimal.Parse(nodoprod.SelectSingleNode("Precio").InnerText, CultureInfo.CreateSpecificCulture("es-AR")));
                            Pr.PPM = PPM;
                            break;
                    }
                }
            }

            return Pr;

        }


    }
}
