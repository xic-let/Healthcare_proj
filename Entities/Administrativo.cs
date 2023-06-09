﻿using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace saude_distante_login.Entities
{
	public class Administrativo : Colaborador
	{
		//Construtores da classe Administrativo

		public Administrativo(string nome, Genero genero, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, int equipa, string password)
			: base(nome, genero, contacto, morada, concelho, email, idColaborador, funcao, vencimento, equipa)
		{

		}
		
		public Administrativo()
		{

		}


		//Métodos da classe Administrativo

		public void MostrarMenuAdministrativo()
		{
			Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine("Bem-vindo/a " + this.Nome);
			Console.WriteLine("MENU ADMINISTRATIVO");
			Console.WriteLine();
			Console.WriteLine("Selecione uma opção:");
			Console.WriteLine();
			Console.WriteLine("1. Adicionar Equipa");
			Console.WriteLine("2. Agendar Rotas");
			Console.WriteLine("3. Consultar Rotas Agendadas");
			Console.WriteLine("4. Consultar Relatório de Colaboradores");
			Console.WriteLine("5. Consultar Relatório Estatístico");
			Console.WriteLine("6. Notificar Utentes");
			Console.WriteLine("7. Sair");
			Console.WriteLine();
			Console.Write("Opção (1-7): ");
			Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
			string? opcao = Console.ReadLine();

			switch (opcao)
			{
				case "1":
					RegistarColaboradores(); 
					break;
				case "2":
					Rotas rotas = new Rotas();
                    rotas.AdicionarRota();
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
				Rotas rot = new Rotas();
					rot.EnviarEmail();
					break;
				case "7":
					Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
					Environment.Exit(0);
					break;
				default:
					Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
					break;
			}
		}

		public void RegistarColaboradores()
		{ 
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
				
				Console.Write("Género: ");
				Genero genero;
				if (!Enum.TryParse(Console.ReadLine(), out genero))
				{
					Console.WriteLine("Género inválido. Tente novamente.");
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

				Console.Write("Equipa: ");
				int equipa;
				if (!int.TryParse(Console.ReadLine(), out equipa))
				{
					Console.WriteLine("Equipa inválida. Tente novamente.");
					i--;
					continue;
				}

				Colaborador novocolaborador = new Colaborador(nome, genero, contacto, morada, concelho, email, idColaborador, funcao, vencimento, equipa);
			
				Listas.Colaboradores.Add(novocolaborador);
                Console.WriteLine();
            }

            if (n == 1)
            {
                Console.WriteLine("Colaborador registado com sucesso.");
            }
            else
            {
                Console.WriteLine("Colaboradores registados com sucesso.");
            }

            Console.WriteLine();

            Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
            string resposta = Console.ReadLine();
            if (resposta == "nao")
            {
                Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                Environment.Exit(0);
            }
            else
            {
                MostrarMenuAdministrativo();
            }
        }

/// /////////////////////////////////////////////////////////////////////////

		public void ListarColaboradores()
		{
            Console.OutputEncoding = Encoding.UTF8;     //	permite imprimir o símbolo € na consola

            Console.WriteLine("Lista de Colaboradores: ");
            int x;
			for (x = 0; x < Listas.Colaboradores.Count; x++)
			{
				Console.Write("Nome: ");
				Console.WriteLine(Listas.Colaboradores[x].Nome);
				Console.Write("Vencimento em €: ");
				Console.WriteLine(Listas.Colaboradores[x].Vencimento);
				Console.Write("Função: ");
				Console.WriteLine(Listas.Colaboradores[x].Funcao);
				Console.Write("Equipa: ");
				Console.WriteLine(Listas.Colaboradores[x].Equipa);
                Console.WriteLine();
            }

            Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
            string resposta = Console.ReadLine();
            if (resposta == "nao")
            {
                Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                Environment.Exit(0);
            }
            else
            {
                MostrarMenuAdministrativo();
            }
        }

		public void ListarColaboradoresPorEquipa()
		{
            Console.OutputEncoding = Encoding.UTF8;		//	permite imprimir o símbolo € na consola
            
			Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine("Escolha a equipa: ");
			Console.WriteLine("1 - Equipa 1");
			Console.WriteLine("2 - Equipa 2");
			Console.WriteLine("3 - Equipa 3");
			Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
			int opcao = Convert.ToInt32(Console.ReadLine());



			if (opcao == 1)
			{
                Console.WriteLine("Colaboradores da Equipa 1");
                int x;
				for (x = 0; x < Listas.Colaboradores.Count; x++)
				{
					if (Listas.Colaboradores[x].Equipa == 1)
					{
						Console.Write("Nome: ");
						Console.WriteLine(Listas.Colaboradores[x].Nome);
						Console.Write("Vencimento em €: ");
						Console.WriteLine(Listas.Colaboradores[x].Vencimento);
						Console.Write("Função: ");
						Console.WriteLine(Listas.Colaboradores[x].Funcao);
						Console.Write("Equipa: ");
						Console.WriteLine(Listas.Colaboradores[x].Equipa);
						Console.WriteLine();
					}
				}
			}
			else if (opcao == 2)
			{
                Console.WriteLine("Colaboradores da Equipa 2");
                int x;
				for (x = 0; x < Listas.Colaboradores.Count; x++)
				{
					if (Listas.Colaboradores[x].Equipa == 2)
					{
                        Console.Write("Nome: ");
                        Console.WriteLine(Listas.Colaboradores[x].Nome);
                        Console.Write("Vencimento em €: ");
                        Console.WriteLine(Listas.Colaboradores[x].Vencimento);
                        Console.Write("Função: ");
                        Console.WriteLine(Listas.Colaboradores[x].Funcao);
                        Console.Write("Equipa: ");
                        Console.WriteLine(Listas.Colaboradores[x].Equipa);
                        Console.WriteLine();
                    }
				}
			}
			else if (opcao == 3)
			{
                Console.WriteLine("Colaboradores da Equipa 3");
                int x;
				for (x = 0; x < Listas.Colaboradores.Count; x++)
				{
					if (Listas.Colaboradores[x].Equipa == 3)
					{
                        Console.Write("Nome: ");
                        Console.WriteLine(Listas.Colaboradores[x].Nome);
                        Console.Write("Vencimento em €: ");
                        Console.WriteLine(Listas.Colaboradores[x].Vencimento);
                        Console.Write("Função: ");
                        Console.WriteLine(Listas.Colaboradores[x].Funcao);
                        Console.Write("Equipa: ");
                        Console.WriteLine(Listas.Colaboradores[x].Equipa);
                        Console.WriteLine();
                    }
				}
			}
            else
            {
                Console.WriteLine("Não existe Equipa " + opcao + ". Tente novamente.");
				ListarColaboradoresPorEquipa();
            }

            Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
            string resposta = Console.ReadLine();
            if (resposta == "nao")
            {
                Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                Environment.Exit(0);
            }
            else
            {
                MostrarMenuAdministrativo();
            }
        }
		
		public void RelatorioColaboradores()
		{
			Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine("Deseja imprimir Relatório Geral ou Relatório por Equipa?");
			Console.WriteLine("1 - Relatório Geral");
			Console.WriteLine("2 - Relatório por Equipa");
			Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
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
				RelatorioColaboradores();
			}

            Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
            string resposta = Console.ReadLine();
            if (resposta == "nao")
            {
                Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                Environment.Exit(0);
            }
            else
            {
                MostrarMenuAdministrativo();
            }
        }


	}

}



