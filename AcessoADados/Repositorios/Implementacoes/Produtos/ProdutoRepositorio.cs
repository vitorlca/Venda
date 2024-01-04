using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;

namespace AcessoADados.Repositorios.Implementacoes.Produtos
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public static List<Produto> Produtos { get; set; }
        static ProdutoRepositorio()
        {
            Produtos = new List<Produto>();
        }
        public void EditarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }
        public void InserirProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
        public Produto SelecionarProduto(int idProduto)
        {
            Produto produtoSelecionado = Produtos.FirstOrDefault(x => x.Id == idProduto);
            return produtoSelecionado;
        }
        public void RemoverProduto(int idProduto)
        {
            Produto produtoParaRemover = SelecionarProduto(idProduto);
            if (produtoParaRemover != null)
            {
                Produtos.Remove(produtoParaRemover);
            }
        }
        public bool VerificarExisteProduto(int idProduto)
        {
            bool existeProduto = Produtos.Any(x => x.Id == idProduto);
            return existeProduto;
        }
        public List<Produto> SelecionarListagem()
        {
            return Produtos;
        }
    }
}
