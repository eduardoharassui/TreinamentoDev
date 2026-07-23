using Dominio.Modelos;
using Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TreinamentoDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly IVendaServico _vendaServico;

        public VendasController(IVendaServico vendaServico)
        {
            _vendaServico = vendaServico;
        }

        [HttpPost]
        public IActionResult Inserir(VendaModel venda)
        {
            _vendaServico.Inserir(venda);
            return Ok();
        }

        [HttpPut]
        public IActionResult Alterar(VendaModel venda)
        {
            _vendaServico.Alterar(venda);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Deletar(VendaModel venda)
        {
            _vendaServico.Deletar(venda);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<VendaModel>> Listar()
        {
            return Ok(_vendaServico.Listar());
        }
    }
}