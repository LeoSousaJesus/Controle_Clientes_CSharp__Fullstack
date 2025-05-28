using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    // Classe que representa uma pessoa jurídica, herda de Clientes
    public class Pessoa_Juridica : Clientes
    {
        // Propriedade para armazenar o CNPJ da pessoa jurídica
        public string cnpj { get; set; }
        // Propriedade para armazenar a inscrição estadual (IE) da pessoa jurídica
        public string ie { get; set; }

        // Sobrescreve o método para calcular imposto específico de pessoa jurídica
        public override void Pagar_Imposto(float v)
        {
            this.valor = v; // Define o valor base
            this.valor_imposto = this.valor * 0.2f; // Imposto de 20% para Pessoa Jurídica
            this.total = this.valor + this.valor_imposto; // Soma valor base e imposto
        }
    }
}