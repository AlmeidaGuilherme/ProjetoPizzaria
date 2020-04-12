using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontMVC.Models
{
    public class Pedido
    {
        public int ID { get; set; }
        public int PizzaID { get; set; }
        public int ClienteID { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public bool Entregue { get; set; }
    }
}