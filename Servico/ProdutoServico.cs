using Dominio.Modelos;
using Dominio.Repositorios;
using Dominio.Servico;
using Dominio.Servicos;
using Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
namespace Servico
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoServico(IProdutoRepositorio repositorio)
        {
            _produtoRepositorio = repositorio;
        }
        public void Alterar(ProdutoModel produto)
        {
            _produtoRepositorio.Alterar(produto);
        }
        public void Deletar(ProdutoModel produto)
        {
            _produtoRepositorio.Deletar(produto);
        }
        public void Inserir(ProdutoModel produto)
        {
            _produtoRepositorio.Inserir(produto);
        }
        public List<ProdutoModel> Listar()
        {
            return _produtoRepositorio.Listar();
        }
    }
}