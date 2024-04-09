using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ACTIVIDADES
{
    class Base_de_Datos
    {
        XmlDocument doc;
        string rutaXml;

        public void CrearXml (string ruta, string nodoRaiz)
        {
            this.rutaXml = ruta;
            doc = new XmlDocument();

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlNode element1 = doc.CreateElement(nodoRaiz);
            doc.AppendChild(element1);
            doc.Save(ruta);
        }

        public void Anañdir(string titulo, string descripcion)
        {
            doc.Load(rutaXml);

            XmlNode actividad = Crear_Actividad(titulo, descripcion);

            XmlNode nodoRaiz = doc.DocumentElement;
            nodoRaiz.InsertAfter(actividad, nodoRaiz.LastChild);
            doc.Save(rutaXml);
        }

        private XmlNode Crear_Actividad(string titulo, string descripcion)
        {
            XmlNode actividad = doc.CreateElement("Actividad");

            XmlElement xtitulo = doc.CreateElement("titulo");
            xtitulo.InnerText = titulo;
            actividad.AppendChild(xtitulo);

            XmlElement xdescripcion = doc.CreateElement("descripcion");
            xdescripcion.InnerText = descripcion;
            actividad.AppendChild(xdescripcion);

            return actividad;
        }

        public void ReadXml()
        {
            doc.LoadXml(rutaXml);

            XmlNodeList listaActividades = doc.SelectNodes("NodoRaiz/Actividad");

            XmlNode unaActicidad;

            for (int i = 0; i < listaActividades.Count; i++)
            {
                unaActicidad = listaActividades.Item(i);

                string titulo = unaActicidad.SelectSingleNode("titulo").InnerText;
                string descripcion = unaActicidad.SelectSingleNode("descripcion").InnerText;

                Console.WriteLine("titulo: {0}, descripcion: {1}\n", titulo, descripcion);
            }
        }

        public void Borra(string titulo_borrar)
        {
            doc.LoadXml(rutaXml);

            XmlElement actividades = doc.DocumentElement;

            XmlNodeList listaActicidades = doc.SelectNodes("NodoRaiz/Actividad");

            foreach (XmlNode item in listaActicidades)
            {
                if (item.SelectSingleNode("titulo").InnerText == titulo_borrar)
                {
                    XmlNode nodoOld = item;
                    actividades.RemoveChild(nodoOld);
                }
            }

            doc.Save(rutaXml);
        }


        public void Modifica (string titulo_modifica, string descripcion)
        {
            XmlElement actividades = doc.DocumentElement;

            XmlNodeList listaActicidades = doc.SelectNodes("NodoRaiz/Actividad");

            XmlNode nuevos_datos = Crear_Actividad(titulo_modifica, descripcion);

            foreach(XmlNode item in listaActicidades)
            {
                if (item.FirstChild.InnerText == titulo_modifica)
                {
                    XmlNode nodoOld = item;
                    actividades.ReplaceChild(nuevos_datos, nodoOld);
                }
            }

            doc.Save(rutaXml);
        }


    }
}
