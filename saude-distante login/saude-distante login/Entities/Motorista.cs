using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    internal class Motorista : Colaborador
    {
        //Construtores da classe Motorista
        public Motorista()
        {

        }

        public Motorista(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, double vencimento, Equipa equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, concelho, email, idColaborador, vencimento, equipa, password)
        {

        }


        //Métodos da classe Motorista


        public bool Autenticar(string funcao, string email, string password)
        {
            return base.Email == email && base.Password == password && funcao.ToLower() == "motorista";
        }

        public override void AcessoPermitido()
        {
            base.AcessoPermitido();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Verificar plano de rota");
            Console.WriteLine("2. Aceder relatório estatístico");
            Console.WriteLine("3. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-3): ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    VerPlanoRota();
                    break;
                case "2":
                    RelEstatistico();
                    break;
                case "3":
                    //Logout
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }
    }
}
