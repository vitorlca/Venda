using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;
using AcessoADados.Repositorios.Implementacoes.Produtos;

namespace Negocio.Servicos.Implementacoes.Produtos
{
    public class ProdutoService : IProdutoService
    {
        public readonly IProdutoRepositorio repositorioProduto;
        public ProdutoService()
        {
            repositorioProduto = new ProdutoRepositorio();
        }
        public void EditarProduto(Produto produto)
        {
            bool existeProduto = repositorioProduto.VerificarExisteProduto(produto.Id);
            if (existeProduto)
            {
                repositorioProduto.EditarProduto(produto);
            }
            else
            {
                throw new Exception("Essa Produto não existe");
            }
        }

        public void InserirProduto(Produto produto)
        {
            bool existeProduto = repositorioProduto.VerificarExisteProduto(produto.Id);
            if (existeProduto)
            {
                throw new Exception("Essa Produto ja existe");
            }
            else
            {
                repositorioProduto.InserirProduto(produto);
            }
        }

        public void RemoverProduto(int idProduto)
        {
            try
            {
                repositorioProduto.RemoverProduto(idProduto);
            }
            catch (Exception)
            {
                //tratar erro
                throw;
            }
        }

        public Produto SelecionarProduto(int idProduto)
        {
            Produto produtoSelecionada = repositorioProduto.SelecionarProduto(idProduto);
            return produtoSelecionada;
        }

        public List<Produto> SelecionarListagem()
        {
            List<Produto> produtos = repositorioProduto.SelecionarListagem();

            return produtos;
        }
    }
}
