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

        public void MostrarMenuMotorista()
        {
            while (true)
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
                        Console.WriteLine();
                        VerPlanoRota();
                        break;
                    case "2":
                        RelConsultas();
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                        break;

                }
            }

        }
        public void VerPlanoRota()
        {
            List<Rotas> rotas = Listas.rotas;

            foreach (var rota in rotas)
            {
                Console.WriteLine($"ID da Rota: {rota.IdRota}");
                Console.WriteLine($"Concelho: {rota.Concelho}");
                Console.WriteLine($"Freguesia: {rota.Freguesia}");
                Console.WriteLine($"Equipa: {rota.Equipa}");
                Console.WriteLine($"Data e Hora: {rota.Data}");
                Console.WriteLine();
            }
        }
    }
}
