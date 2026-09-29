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

        }

        public static void TelaLogin()
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
        }
    }
}
