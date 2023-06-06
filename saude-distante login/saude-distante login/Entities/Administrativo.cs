using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using saude_distante_login.Services;

namespace saude_distante_login.Entities
{
    internal class Administrativo : Colaborador, IAutenticacao
    {
        //Construtores da classe Administrativo
        //public Administrativo() {}

        public List<Colaborador> Colaboradores = new List<Colaborador>();

        public Administrativo(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, Equipa equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, concelho, email, idColaborador, funcao, vencimento, equipa, password)
        {

        }


        //Métodos da classe Administrativo

        public bool Autenticar(string funcao, string email, string password)
        {
            return base.Email == email && base.Password == password && funcao.ToLower() == "administrativo";
        }

        public override void AcessoPermitido()
        {
            base.AcessoPermitido();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Adicionar Equipa");
            Console.WriteLine("2. Aceder Relatório de Colaboradores");
            Console.WriteLine("3. Aceder Relatório Estatístico");
            Console.WriteLine("4. Agendar Rota"); //o email é enviado automaticamente ao fazer o registo da rota
            Console.WriteLine("5. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-5): ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    RegistarEquipa(); //resolver equipas
                    break;
                case "2":
                    RelatorioColaboradores();
                    break;
                case "3":
                    RelEstatistico();
                    break;
                case "4":
                    AdicionarRota(); //resolver equipas
                    break;
                case "5":
                    //Logout
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }

        public void RegistarColaboradores()
        {
            Console.Write("Número de colaboradores a registar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Qual a função do colaborador?");
                Console.WriteLine("1 - Administrativo");
                Console.WriteLine("2 - Enfermeiro");
                Console.WriteLine("3 - Médico");
                Console.WriteLine("4 - Motorista");
                int res = int.Parse(Console.ReadLine());
                string funcao = "";
                if (res == 1)
                {
                    funcao = "Administrativo";
                }
                else if (res == 2)
                {
                    funcao = "Enfermeiro";
                }
                else if (res == 3)
                {
                    funcao = "Medico";
                }
                else
                {
                    funcao = "Motorista";
                }

                Console.WriteLine("Dados do colaborador:");
                Console.Write("ID: ");
                int idColaborador = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Vencimento: ");
                double vencimento = double.Parse(Console.ReadLine());
                Console.WriteLine("Equipa: ");
                int equipa = int.Parse(Console.ReadLine());

                Colaborador colaborador = new Colaborador();
                colaborador.IdColaborador = idColaborador;
                colaborador.Nome = nome;
                colaborador.Vencimento = vencimento;
                colaborador.Equipa = equipa;

                Colaboradores.Add(colaborador);

                //Colaboradores.Add(equipa + ", " + idColaborador + ", " + nome + ", " + funcao + ", " + vencimento);
            }
        }

        public void RelatorioColaboradores()
        {
            Colaboradores.Sort();
            /*
            foreach (string colaborador in Colaboradores)
            {
                Console.WriteLine("Equipa " + colaborador);
            }
            */
            foreach (Colaborador colaborador in Colaboradores)
            {
                Console.WriteLine("Equipa " + Colaboradores);
            }
        }

        

        

        public void RelatorioEquipa(int idEquipa)
        {
            foreach (Equipa equipa in Equipas)
            {
                if (idEquipa == equipa.IdEquipa)
                {
                    Console.WriteLine("Equipa " + equipa.IdEquipa + " (" + equipa.Concelho + "):\n"
                     + "Administrativo: " + equipa.Administrativo.Nome + " (vencimento: " + equipa.Administrativo.Vencimento + "€)\n"
                     + "Enfermeiro: " + equipa.Enfermeiro.Nome + " (vencimento: " + equipa.Enfermeiro.Vencimento + "€)\n"
                     + "Médico: " + equipa.Medico.Nome + " (vencimento: " + equipa.Medico.Vencimento + "€)\n"
                     + "Motorista: " + equipa.Motorista.Nome + " (vencimento: " + equipa.Motorista.Vencimento + "€)");
                    Console.WriteLine();
                }
            }


        public void AdicionarRota(Rotas novaRota, List<Rotas> rotas) //resolver equipas para nao dar erro
        {
            rotas.Add(novaRota);

            rotas.Add(1, Enums.Concelho.Braga, "Sao Vitor", equipa1);
            rotas.Add(2, Enums.Concelho.Braga, "Gualtar", equipa1);
            rotas.Add(3, Enums.Concelho.Amares, "Amares e Figueiredo", equipa2);
            rotas.Add(4, Enums.Concelho.Amares, "Dornelas", equipa2);
            rotas.Add(5, Enums.Concelho.Guimarães, "Azurém", equipa3);
            rotas.Add(6, Enums.Concelho.Guimarães, "Creixomil", equipa3);
        }
    }

}



