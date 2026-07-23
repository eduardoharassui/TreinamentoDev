using Dominio.Modelos;
using System.Collections.Generic;
using System.Linq;
namespace Infraestrutura.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly AppDBContext _context;
        public ProdutoRepositorio(AppDBContext context)
        {
            _context = context;
        }
        public void Alterar(ProdutoModel produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
        public void Deletar(ProdutoModel produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
        public void Inserir(ProdutoModel produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
        public List<ProdutoModel> Listar()
        {
            return _context.Produtos.ToList();
        }
        public ProdutoModel Consultar(int codigo)
        {
            return _context.Produtos.FirstOrDefault(p => p.Codigo == codigo);
        }
    }
}