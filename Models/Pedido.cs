using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPublisherApp.Models
{
    public class Pedido
    {
        public string NomeCliente { get; set; } = string.Empty;
        public string Produto { get; set; } = string.Empty;
        public int Quantidade { get; set; } 
    }
}