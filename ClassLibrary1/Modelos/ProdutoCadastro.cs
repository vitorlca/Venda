using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class ProdutoCadastro
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
    }
}
