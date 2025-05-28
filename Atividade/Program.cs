using System;
namespace Atividade
{

    class Program
    {
        static void Main(string[] args)
        {
            // Solicita o nome do usuário
            Console.WriteLine("Digite seu nome:");
            string var_nome = Console.ReadLine();

            // Solicita o endereço do usuário
            Console.WriteLine("Digite seu endereço:");
            string var_endereco = Console.ReadLine();

            // Pergunta se é pessoa física ou jurídica
            Console.WriteLine("Digite (f) para Pessoa Física ou (j) para Pessoa Jurídica:");
            string var_tipo = Console.ReadLine();

            // Se for pessoa física
            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica(); // Cria objeto Pessoa_Fisica
                pf.nome = var_nome; // Atribui nome
                pf.endereco = var_endereco; // Atribui endereço
                Console.WriteLine("Informe o seu CPF:");
                pf.cpf = Console.ReadLine(); // Lê CPF
                Console.WriteLine("Informe o seu RG:");
                pf.rg = Console.ReadLine(); // Lê RG
                Console.WriteLine("Informe o valor da compra:");
                float valor_pagamento = float.Parse(Console.ReadLine()); // Lê valor da compra
                pf.Pagar_Imposto(valor_pagamento); // Calcula imposto
                Console.WriteLine($"Nome: {pf.nome}, Total a pagar : {pf.total}"); // Exibe resultado
            }

            // Se for pessoa jurídica
            else if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica(); // Cria objeto Pessoa_Juridica
                pj.nome = var_nome; // Atribui nome
                pj.endereco = var_endereco; // Atribui endereço
                Console.WriteLine("Informe o seu CNPJ:");
                pj.cnpj = Console.ReadLine(); // Lê CNPJ
                Console.WriteLine("Informe a sua Inscrição Estadual:");
                pj.ie = Console.ReadLine(); // Lê inscrição estadual
                Console.WriteLine("Informe o valor da compra:");
                float valor_pagamento = float.Parse(Console.ReadLine()); // Lê valor da compra
                pj.Pagar_Imposto(valor_pagamento); // Calcula imposto
                Console.WriteLine($"Nome: {pj.nome}, Total a pagar : {pj.total}"); // Exibe resultado
            }
            else
            {
                // Caso o tipo seja inválido
                Console.WriteLine("Tipo de cliente inválido.");
            }

        }
    }

}