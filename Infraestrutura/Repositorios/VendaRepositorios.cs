using System.Collections.Generic;
using Dominio.Modelos;

namespace Infraestrutura.Repositorios
{
    public class VendaRepositorio : IVendaRepositorio
    {
        private readonly AppDBContext _context;

        public VendaRepositorio(AppDBContext context)
        {
            _context = context;
        }

        public void Alterar(VendaModel venda)
        {
            _context.Vendas.Update(venda);
            _context.SaveChanges();
        }

        public void Deletar(VendaModel venda)
        {
            _context.Vendas.Remove(venda);
            _context.SaveChanges();
        }

        public void Inserir(VendaModel venda)
        {
            _context.Vendas.Add(venda);
            _context.SaveChanges();
        }

        public List<VendaModel> Listar()
        {
            return _context.Vendas.ToList();
        }
    }
}