using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    public class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set; }
        public string ie { get; set; }

        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 0.2f; // Imposto de 20% para Pessoa Jurídica
            this.total = this.valor + this.valor_imposto;
        }
    }
}