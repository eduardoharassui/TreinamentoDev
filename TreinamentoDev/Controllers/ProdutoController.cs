using Dominio.Modelos;
using Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TreinamentoDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoServico _produtoServico;

        public ProdutosController(IProdutoServico produtoServico)
        {
            _produtoServico = produtoServico;
        }

        [HttpPost]
        public IActionResult Inserir(ProdutoModel produto)
        {
            _produtoServico.Inserir(produto);
            return Ok();
        }

        [HttpPut]
        public IActionResult Alterar(ProdutoModel produto)
        {
            _produtoServico.Alterar(produto);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Deletar(ProdutoModel produto)
        {
            _produtoServico.Deletar(produto);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<ProdutoModel>> Listar()
        {
            return Ok(_produtoServico.Listar());
        }
    }
}