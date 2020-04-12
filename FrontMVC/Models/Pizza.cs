using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontMVC.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}