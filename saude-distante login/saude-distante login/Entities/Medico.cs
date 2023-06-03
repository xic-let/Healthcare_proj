using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    internal class Medico : Colaborador
    {
        //Construtores da classe Medico
        public Medico()
        {

        }

        public Medico(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Distrito distrito, string email, int idColaborador, double vencimento, Equipa equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, distrito, email, idColaborador, vencimento, equipa, password)
        {

        }


        //Métodos da classe Medico


        public bool Autenticar(string funcao, string email, string password)
        {
            // Verificar se a função informada é "médico"
            return base.Email == email && base.Password == password && funcao.ToLower() == "médico";
        }

        public override void AcessoPermitido()
        {
            base.AcessoPermitido();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Realizar consulta");
            Console.WriteLine("2. Aceder relatório estatístico nacional");
            Console.WriteLine("3. Aceder relatório estatístico semanal");
            Console.WriteLine("4. Aceder relatório estatístico diário");
            //Console.WriteLine("5. Aceder relatório consultas");
            Console.WriteLine();
            Console.Write("Opção (1-4: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    RegistarConsultaMed();
                    break;
                case "2":
                    RelEstatisticoNacional();
                    break;
                case "3":
                    RelEstatisticoSemanal();
                    break;
                case "4":
                    RelEstatisticoDiario();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }

        
    }
}
