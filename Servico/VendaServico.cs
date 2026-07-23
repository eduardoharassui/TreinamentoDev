using Dominio.Modelos;
using Dominio.Servicos;
using Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class VendaServico : IVendaServico
    {
        private readonly IVendaRepositorio _vendaRepositorio;

        public VendaServico(IVendaRepositorio repositorio)
        {
            _vendaRepositorio = repositorio;
        }

        public void Alterar(VendaModel venda)
        {
            _vendaRepositorio.Alterar(venda);
        }

        public void Deletar(VendaModel venda)
        {
            _vendaRepositorio.Deletar(venda);
        }

        public void Inserir(VendaModel venda)
        {
            _vendaRepositorio.Inserir(venda);
        }

        public List<VendaModel> Listar()
        {
            return _vendaRepositorio.Listar();
        }
    }
}