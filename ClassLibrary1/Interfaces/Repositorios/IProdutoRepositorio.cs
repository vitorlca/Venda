using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorios
{
    public interface IProdutoRepositorio
    {
        void InserirProduto(Produto produto);
        void EditarProduto(Produto produto);
        void RemoverProduto(int idProduto);
        Produto SelecionarProduto(int idProduto);
        List<Produto> SelecionarListagem();
        bool VerificarExisteProduto(int idProduto);
    }
}
