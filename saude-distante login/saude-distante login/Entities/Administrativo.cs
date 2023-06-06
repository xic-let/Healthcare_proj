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
        public Administrativo() { }

        public List<Colaborador> Colaboradores = new List<Colaborador>();


        public Administrativo(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, int equipa, string password)
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
            Console.WriteLine("2. Agendar Rotas");
            Console.WriteLine("3. Consultar Rotas Agendadas");
            Console.WriteLine("4. Consultar Relatório de Colaboradores");
            Console.WriteLine("5. Consultar Relatório Estatístico"); //o email é enviado automaticamente ao fazer o registo da rota
            Console.WriteLine("6. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-6): ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                
                    RegistarColaboradores(); 
                    break;
                case "2":
                    Rotas rotas = new Rotas();
                    rotas.AgendaRotas();
                    break;
                case "3":
                    Rotas rotas = new Rotas();
                    rotas.VerAgenda(); 
                    break;
                case "4":
                    RelatorioColaboradores();
                    break;
                case "5":
                    Colaborador colaborador = new Colaborador();
                    colaborador.RelEstatistico();
                    break;
                case "6":
                    Rotas rotas = new Rotas();
                    rotas.VerAgenda(); 
                    break;
                case "7":
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
                string funcao;
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
                Console.WriteLine("Género: ");
                Genero genero = Enum.Parse<Genero>(Console.ReadLine());
                Console.Write("Data de nascimento: ");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Contacto: ");
                string contacto = Console.ReadLine();
                Console.Write("Morada: ");
                string morada = Console.ReadLine();
                Console.Write("Concelho: ");
                Concelho concelho = Enum.Parse<Concelho>(Console.ReadLine());
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Vencimento: ");
                double vencimento = double.Parse(Console.ReadLine());
                Console.Write("Password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Equipa: ");
                int equipa = int.Parse(Console.ReadLine());

                Colaborador colaborador = new Colaborador(equipa, nome, genero, dataNascimento, contacto, morada, concelho, email, idColaborador, funcao, vencimento, password);

                Colaboradores.Add(colaborador);

                
            }
        }

       public void RelatorioColaboradores()
        {
            Console.WriteLine("Deseja imprimir Relatório Geral ou Relatório por Equipa?");
            Console.WriteLine("1 - Relatório Geral");
            Console.WriteLine("2 - Relatório por Equipa");
            int res = int.Parse(Console.ReadLine());

            if (res == 1)
            {
                Colaborador colaborador = new Colaborador();
                colaboradores.ListarColaboradores();


                /*Console.WriteLine("Relatório Geral");
                Console.WriteLine();
                foreach (Colaborador colaborador in Colaboradores)
                {
                    Console.WriteLine("ID: " + colaborador.IdColaborador);
                    Console.WriteLine("Nome: " + colaborador.Nome);
                    Console.WriteLine("Vencimento: " + colaborador.Vencimento);
                    Console.WriteLine();
                }*/
            }
            else
            {
                Colaborador colaborador = new Colaborador();
                colaboradores.ListarColaboradoresPorEquipa();

                /*Console.WriteLine("Relatório por Equipa");
                Console.WriteLine();
                
                
                Console.Write("ID da equipa: ");
                int idEquipa = int.Parse(Console.ReadLine());

                foreach (Colaborador colaborador in Colaboradores)
                {
                    if (idEquipa == colaborador.Equipa)
                    {
                        Console.WriteLine("ID: " + colaborador.IdColaborador);
                        Console.WriteLine("Nome: " + colaborador.Nome);
                        Console.WriteLine("Vencimento: " + colaborador.Vencimento);
                        Console.WriteLine("Equipa: " + colaborador.Equipa);
                        Console.WriteLine();
                    }
                }*/
            }
        }

      
        /*Colaboradores.Sort();
           
            foreach (Colaborador colaborador in equipa1)
            {   
                int i = 0;
                Console.WriteLine("Equipa " + Colaborador.colaborador[i].nome  + "vencimento " + Colaboradores + "€");
            }

        

        /*public void RelatorioEquipa(int idEquipa)
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
            }*/

    }

}



