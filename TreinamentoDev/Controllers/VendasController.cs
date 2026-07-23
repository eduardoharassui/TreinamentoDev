using Dominio.Modelos;
using Dominio.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TreinamentoDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase, IVendaServico
    {
        [HttpPut]
        public void Alterar(VendaModel venda)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public void Deletar(VendaModel venda)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void Inserir(VendaModel venda)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public List<VendaModel> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
