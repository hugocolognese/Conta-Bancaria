using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_01.Classes
{
    public class Layout
    {
        private static List <Pessoa> pessoas = new List<Pessoa>();
        private static int opcao = 0;
        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗░█████╗░  ██████╗░░█████╗░███╗░░██╗░█████╗░░█████╗░██████╗░██╗░█████╗░
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░███████║  ██████╦╝███████║██╔██╗██║██║░░╚═╝███████║██████╔╝██║███████║
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██║  ██╔══██╗██╔══██║██║╚████║██║░░██╗██╔══██║██╔══██╗██║██╔══██║
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║  ██████╦╝██║░░██║██║░╚███║╚█████╔╝██║░░██║██║░░██║██║██║░░██║
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚═╝");

            Console.WriteLine("//////////////////////////////////////////");
            Console.WriteLine("           1- Criar Conta");
            Console.WriteLine("           2- Entrar na conta");
            Console.WriteLine("//////////////////////////////////////////");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    TelaLogin();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        public static void TelaCriarConta()
        {
            Console.Clear();
            Console.WriteLine("Tela de criação de conta");
            Console.WriteLine("//////////////////////////////////////////");
            Console.WriteLine("           Nome:                          ");
            string nome = Console.ReadLine();
            Console.WriteLine("           CPF:                           ");
            string cpf = Console.ReadLine();
            Console.WriteLine("           Senha:                         ");
            string senha = Console.ReadLine();
            Console.WriteLine("//////////////////////////////////////////");

            ContaCorrente contaCorrente = new ContaCorrente();
            Pessoa pessoa = new Pessoa();

            pessoa.SetNome(nome);
            pessoa.SetCPF(cpf);
            pessoa.SetSenha(senha);
            pessoa.Conta = contaCorrente;

            pessoas.Add(pessoa);

            Console.Clear();
            Console.WriteLine("Conta criada com sucesso!");

            Thread.Sleep(2000);
            TelaContaLogada(pessoa);
        }

        private static void TelaLogin()
        {
             Console.Clear();
            Console.WriteLine("Tela de Login");
            Console.WriteLine("//////////////////////////////////////////");
            Console.WriteLine("           CPF:                           ");
            string cpf = Console.ReadLine();
            Console.WriteLine("           Senha:                         ");
            string senha = Console.ReadLine();
            Console.WriteLine("//////////////////////////////////////////");

            Pessoa pessoa = pessoas.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha);

            if(pessoa != null)
            {
                TelaBoasVindas(pessoa);
                TelaContaLogada(pessoa);
            } 
            else
            {
                Console.Clear();
                Console.WriteLine("Conta criada com sucesso!");
            }
        }

        private static void TelaBoasVindas(Pessoa pessoa)
        {
            Console.WriteLine($"Seja Bem Vindo {pessoa.Nome}");
        }

        private static void TelaContaLogada(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("Digite a opcao desejada: ");
            Console.WriteLine("1- Depositar");
            Console.WriteLine("2- Sacar");
            Console.WriteLine("3- Consultar Saldo");
            Console.WriteLine("4- Extrato");
            Console.WriteLine("5- Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        }
    }
}
