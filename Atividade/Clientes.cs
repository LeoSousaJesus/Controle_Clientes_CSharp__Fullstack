using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    // Classe base para clientes
    public class Clientes
    {
        // Propriedade para armazenar o nome do cliente
        public string nome { get; set; }
        // Propriedade para armazenar o endereço do cliente
        public string endereco { get; set; }
        // Valor base para cálculo do imposto
        public float valor { get; protected set; }
        // Valor do imposto calculado
        public float valor_imposto { get; protected set; }
        // Valor total (valor base + imposto)
        public float total { get; protected set; }
 
        // Método virtual para calcular o imposto sobre um valor informado
        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v; // Define o valor base
            this.valor_imposto = this.valor * 0.1f; // Calcula 10% de imposto
            this.total = this.valor + this.valor_imposto; // Soma valor base e imposto
        }
 
    }  
}