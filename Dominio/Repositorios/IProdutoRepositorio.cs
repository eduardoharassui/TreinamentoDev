using System.Collections.Generic;
using Dominio.Modelos;

namespace Infraestrutura.Repositorios
{
    public interface IProdutoRepositorio
    {
        void Alterar(ProdutoModel produto);
        void Deletar(ProdutoModel produto);
        void Inserir(ProdutoModel produto);
        List<ProdutoModel> Listar();
    }
}