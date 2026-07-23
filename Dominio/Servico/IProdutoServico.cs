using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public interface IProdutoServico
    {
        public void Alterar(ProdutoModel produto);
        public void Deletar(ProdutoModel produto);
        public void Inserir(ProdutoModel produto);
        public List<ProdutoModel> Listar();
    }
}
