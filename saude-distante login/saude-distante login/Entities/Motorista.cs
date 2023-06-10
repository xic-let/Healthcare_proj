using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    public class Motorista : Colaborador//, IAutenticacao
    {
        //Construtores da classe Motorista
        public Motorista()
        {

        }

        public Motorista(string nome, Genero genero, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, string password, int equipa) 
            : base(nome, genero, contacto, morada, concelho, email, idColaborador, funcao, vencimento, password, equipa)
        {

        }

        //Métodos da classe Motorista
        List<Rotas> rotas = new List<Rotas>();
        public void MostrarMenuMotorista()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine("Bem-vindo/a " + this.Nome);
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Verificar plano de rota");
            Console.WriteLine("2. Aceder relatório estatístico");
            Console.WriteLine("3. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-3): ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            string opcao = Console.ReadLine();

            

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Plano de rotas: ");
                    List<Rotas> rotasList = new List<Rotas>();
                    Rotas.VerPlanoRota(rotasList);
                    break;
                case "2":
                    RelConsultas();
                    break;
                case "3":
                    Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;

            }
        }
    }
}
