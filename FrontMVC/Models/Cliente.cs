using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontMVC.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public decimal TotalJaPago { get; set; }
    }
}