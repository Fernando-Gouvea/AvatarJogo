using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avatar.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string FormaPagamento { get; set; }
        public string NomeComprador { get; set; }
        public DateTime DataCompra { get; set; }



    }
}