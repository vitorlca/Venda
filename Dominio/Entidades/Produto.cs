using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
    }
}
