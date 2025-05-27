
using System;
namespace Atividade
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Digite seu endereço:");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Digite (f) para Pessoa Física ou (j) para Pessoa Jurídica:");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informe o seu CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe o seu RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra:");
                float valor_pagamento = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(valor_pagamento);
                Console.WriteLine($"Nome: {pf.nome}, Total a pagar : {pf.total}");
            }

            else if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informe o seu CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe a sua Inscrição Estadual:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra:");
                float valor_pagamento = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(valor_pagamento);
                Console.WriteLine($"Nome: {pj.nome}, Total a pagar : {pj.total}");
            }
            else
            {
                Console.WriteLine("Tipo de cliente inválido.");
            }

        }
    }

}