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
    public class VentaMP
    {
        public void Agregar_venta(Venta Ve)
        {


            XDocument xmlventas = XDocument.Load("c:/PanApp/PanApp_BD.xml");

            xmlventas.Element("BD").Add(new XElement("Venta",

                  new XElement("Fecha", Ve.Fecha_venta.ToShortDateString()),
                  new XElement("Nro_pedido", Ve.pr.Nro_pedido),
                  new XElement("DNI", Ve.pr.Obtener_DNI()),
                  new XElement("Importe_total", Ve.Importe_total.ToString())));

            var items = xmlventas.Descendants("Venta")
                  .Where(item => item.Element("Nro_pedido").Value == Convert.ToString(Ve.pr.Nro_pedido));


            foreach (Panificados P in Ve.pr.retorna_lista_panificados())
            {
                foreach (var n in items)
                {
                    n.Add(new XElement("Detalle_producto", new XElement("Nro_lote", P.Nro_lote),
                        new XElement("Unidades", P.Unidades), new XElement("Peso", P.Peso),
                        new XElement("Descripcion", P.Descripcion),
                        new XElement("Precio", P.Leer_precio().ToString())
                        ));
                }
            }



            xmlventas.Save("c:/PanApp/PanApp_BD.xml");
        }




        public decimal[] Graficar_x_intervalo_unidades(DateTime fechaini, DateTime fechafin, bool porcentaje)
        {

            decimal[] lista = new decimal[6];
            XmlDocument xmlventas = new XmlDocument();
            xmlventas.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_ventas = xmlventas.SelectNodes("BD/Venta");
            foreach (XmlNode N in lista_ventas)
            {
                if (Convert.ToDateTime(N.SelectSingleNode("Fecha").InnerText).Date >= fechaini.Date & Convert.ToDateTime(N.SelectSingleNode("Fecha").InnerText).Date <= fechafin.Date)
                {
                    foreach (XmlNode nod in N.SelectNodes("Detalle_producto"))
                    {
                        switch (nod.SelectSingleNode("Descripcion").InnerText)
                        {
                            case "Pan hamburguesa chico":
                                lista[0] += decimal.Parse(nod.SelectSingleNode("Unidades").InnerText);
                                break;
                            case "Pan hamburguesa maxi":
                                lista[1] += decimal.Parse(nod.SelectSingleNode("Unidades").InnerText);
                                break;
                            case "Pan lactal chico":
                                lista[2] += decimal.Parse(nod.SelectSingleNode("Unidades").InnerText);
                                break;
                            case "Pan lactal grande":
                                lista[3] += decimal.Parse(nod.SelectSingleNode("Unidades").InnerText);
                                break;

                            case "Pan pancho chico":
                                lista[4] += decimal.Parse(nod.SelectSingleNode("Unidades").InnerText);
                                break;
                           
                            case "Pan pancho maxi":
                                lista[5] += decimal.Parse(nod.SelectSingleNode("Unidades").InnerText);
                                break;

                        }
                    }
                }

            }
            if (porcentaje == true)
            {
                decimal total = 0;
                foreach (decimal p in lista)
                {
                    total += p;
                }
                for (int I = 0; I < 6; I++)
                {
                    if (lista[I] > 0)
                    { lista[I] = ((lista[I] / total) * 100); }
                }


            }

            return lista;

        }


        public decimal[] Graficar_x_intervalo(DateTime fechaini, DateTime fechafin, bool porcentaje)
        {
            decimal[] lista = new decimal[6];
            XmlDocument xmlventas = new XmlDocument();
            xmlventas.Load("c:/PanApp/PanApp_BD.xml");
            XmlNodeList lista_ventas = xmlventas.SelectNodes("BD/Venta");
            foreach (XmlNode N in lista_ventas)
            {
                if (Convert.ToDateTime(N.SelectSingleNode("Fecha").InnerText).Date >= fechaini.Date & Convert.ToDateTime(N.SelectSingleNode("Fecha").InnerText).Date <= fechafin.Date)
                {
                    foreach (XmlNode nod in N.SelectNodes("Detalle_producto"))
                    {
                        switch (nod.SelectSingleNode("Descripcion").InnerText)
                        {
                            case "Pan hamburguesa chico":
                                lista[0] += decimal.Parse(nod.SelectSingleNode("Precio").InnerText);
                                break;
                            case "Pan hamburguesa maxi":
                                lista[1] += decimal.Parse(nod.SelectSingleNode("Precio").InnerText);
                                break;
                            case "Pan lactal chico":
                                lista[2] += decimal.Parse(nod.SelectSingleNode("Precio").InnerText);
                                break;
                            case "Pan lactal grande":
                                lista[3] += decimal.Parse(nod.SelectSingleNode("Precio").InnerText);
                                break;

                            case "Pan pancho chico":
                                lista[4] += decimal.Parse(nod.SelectSingleNode("Precio").InnerText);
                                break;
                            case "Pan pancho maxi":
                                lista[5] += decimal.Parse(nod.SelectSingleNode("Precio").InnerText);
                                break;

                        }
                    }
                }

            }

            if (porcentaje == true)
            {
                decimal total = 0;
                foreach (decimal p in lista)
                {
                    total += p;
                }
                for (int I = 0; I < 6; I++)
                {
                    if (lista[I] > 0)
                    { lista[I] = ((lista[I] / total) * 100);
                       lista[I]= Decimal.Round(lista[I],2);
                    }
                }
            }


            return lista;

        }

    }
}
