using System.Collections.Generic;
using Dominio.Modelos;

namespace Infraestrutura.Repositorios
{
    public interface IVendaRepositorio
    {
        void Alterar(VendaModel venda);
        void Deletar(VendaModel venda);
        void Inserir(VendaModel venda);
        List<VendaModel> Listar();
    }
}