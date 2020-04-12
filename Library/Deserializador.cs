using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Web.Script.Serialization;

namespace Library
{
    class Deserializador
    {
        public static List<T> Deserializar<T>()
        {
            StreamReader sr = new StreamReader(@"C:\Users\guilherme.almeida\Documents\Projeto\ProjetoPizzaria\Library\SaveFiles\" + typeof(T).Name + ".txt");
            string conteudo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            
            List<T> obj = (List<T>)serializador.Deserialize(conteudo, typeof(T));

            return obj;
        }

    }



}

