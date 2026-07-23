using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class ProdutoModel
    {
        public int CdEmpresa { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
    }
}
