using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public interface IVendaServico
    {
        public void Alterar(VendaModel venda);
        public void Deletar(VendaModel venda);
        public void Inserir(VendaModel venda);
        public List<VendaModel> Listar();
    }
}
