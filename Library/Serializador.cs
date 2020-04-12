using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web.Script.Serialization;

namespace Library
{
    class Serializador
    {
        public static void Serializar(List<object> obj)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\guilherme.almeida\Documents\Projeto\ProjetoPizzaria\Library\SaveFiles\" + obj.GetType().Name + ".txt");
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);
            sw.Write(objSerializado);
            sw.Close();
        }

    }
}
