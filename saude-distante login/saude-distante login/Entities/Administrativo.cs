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
        public List<Colaborador> Colaboradores = new List<Colaborador>();

        public Administrativo(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, int equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, concelho, email, idColaborador, funcao, vencimento, password, equipa)
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
                    Rotas r = new Rotas();
                    r.VerAgenda(); 
                    break;
                case "4":
                    RelatorioColaboradores();
                    break;
                case "5":
   
                    Utente.RelEstatistico();
                    break;

                case "6":
                    //Logout
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }

        public void RegistarColaboradores()
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            
            Console.Write("Número de colaboradores a registar: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Qual a função do colaborador?");
                Console.WriteLine("1 - Administrativo");
                Console.WriteLine("2 - Enfermeiro");
                Console.WriteLine("3 - Médico");
                Console.WriteLine("4 - Motorista");

                int res;
                if (!int.TryParse(Console.ReadLine(), out res) || res < 1 || res > 4)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    i--;
                    continue;
                }

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
        int idColaborador;
        if (!int.TryParse(Console.ReadLine(), out idColaborador))
        {
            Console.WriteLine("ID inválido. Tente novamente.");
            i--;
            continue;
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Género: ");
        Genero genero;
        if (!Enum.TryParse(Console.ReadLine(), out genero))
        {
            Console.WriteLine("Género inválido. Tente novamente.");
            i--;
            continue;
        }

        Console.Write("Data de nascimento: ");
        DateTime dataNascimento;
        if (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.WriteLine("Data de nascimento inválida. Tente novamente.");
            i--;
            continue;
        }

        Console.Write("Contacto: ");
        string contacto = Console.ReadLine();
        Console.Write("Morada: ");
        string morada = Console.ReadLine();

        Console.Write("Concelho: ");
        Concelho concelho;
        if (!Enum.TryParse(Console.ReadLine(), out concelho))
        {
            Console.WriteLine("Concelho inválido. Tente novamente.");
            i--;
            continue;
        }

        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Vencimento: ");
        double vencimento;
        if (!double.TryParse(Console.ReadLine(), out vencimento))
        {
            Console.WriteLine("Vencimento inválido. Tente novamente.");
            i--;
            continue;
        }

        Console.Write("Password: ");
        string password = Console.ReadLine();

        Console.WriteLine("Equipa: ");
        int equipa;
        if (!int.TryParse(Console.ReadLine(), out equipa))
        {
            Console.WriteLine("Equipa inválida. Tente novamente.");
            i--;
            continue;
        }

        Colaborador novocolaborador = new Colaborador(nome, genero, dataNascimento, contacto, morada, concelho, email, idColaborador, funcao, vencimento, password, equipa);
       
        colaboradores.Add(novocolaborador);
    }
}
/// <summary>
/// /////////////////////////////////////////////////////////////////////////
/// </summary>
        public void ListarColaboradores()
        {
      
            int x;
            for (x = 0; x < Colaboradores.Count; x++)
            {
                Console.WriteLine("Lista de Colaboradores: ");
                Console.WriteLine("Nome: ");
                Console.WriteLine(Colaboradores[x].Nome);
                Console.WriteLine("Vencimento em €:");
                Console.WriteLine(Colaboradores[x].Vencimento);
                Console.WriteLine("Função: ");
                Console.WriteLine(Colaboradores[x].Funcao);
                Console.WriteLine("Equipa: ");
                Console.WriteLine(Colaboradores[x].Equipa);
            }
        }

        public void ListarColaboradoresPorEquipa()
        {
            Console.WriteLine("Escolha a equipa: ");
            Console.WriteLine("1 - Equipa 1");
            Console.WriteLine("2 - Equipa 2");
            Console.WriteLine("3 - Equipa 3");
            int opcao = Convert.ToInt32(Console.ReadLine());



            if (opcao == 1)
            {
                int x;
                for (x = 0; x < Colaboradores.Count; x++)
                {
                    if (Colaboradores[x].Equipa == 1)
                    {
                        Console.WriteLine("Lista de Colaboradores: ");
                        Console.WriteLine("Nome: ");
                        Console.WriteLine(Colaboradores[x].Nome);
                        Console.WriteLine("Vencimento em €:");
                        Console.WriteLine(Colaboradores[x].Vencimento);
                        Console.WriteLine("Função: ");
                        Console.WriteLine(Colaboradores[x].Funcao);
                        Console.WriteLine("Equipa: ");
                        Console.WriteLine(Colaboradores[x].Equipa);
                    }
                }
            }
            else if (opcao == 2)
            {
                int x;
                for (x = 0; x < Colaboradores.Count; x++)
                {
                    if (Colaboradores[x].Equipa == 2)
                    {
                        Console.WriteLine("Lista de Colaboradores: ");
                        Console.WriteLine("Nome: ");
                        Console.WriteLine(Colaboradores[x].Nome);
                        Console.WriteLine("Vencimento em €:");
                        Console.WriteLine(Colaboradores[x].Vencimento);
                        Console.WriteLine("Função: ");
                        Console.WriteLine(Colaboradores[x].Funcao);
                        Console.WriteLine("Equipa: ");
                        Console.WriteLine(Colaboradores[x].Equipa);
                    }
                }
            }
            else if (opcao == 3)
            {
                int x;
                for (x = 0; x < Colaboradores.Count; x++)
                {
                    if (Colaboradores[x].Equipa == 3)
                    {
                        Console.WriteLine("Lista de Colaboradores: ");
                        Console.WriteLine("Nome: ");
                        Console.WriteLine(Colaboradores[x].Nome);
                        Console.WriteLine("Vencimento em €:");
                        Console.WriteLine(Colaboradores[x].Vencimento);
                        Console.WriteLine("Função: ");
                        Console.WriteLine(Colaboradores[x].Funcao);
                        Console.WriteLine("Equipa: ");
                        Console.WriteLine(Colaboradores[x].Equipa);
                    }
                }
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
             
                    ListarColaboradores();
           
                }
                else if (res == 2)
                {
                
                    ListarColaboradoresPorEquipa();

                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }


    }

}



