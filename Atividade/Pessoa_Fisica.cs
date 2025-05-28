using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    // Classe que representa uma pessoa física, herda de Clientes
    public class Pessoa_Fisica : Clientes
    {
        // Propriedade para armazenar o CPF da pessoa física
        public string cpf { get; set; }
        // Propriedade para armazenar o RG da pessoa física
        public string rg { get; set; }
    }
}