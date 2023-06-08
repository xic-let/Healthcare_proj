using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace saude_distante_login.Entities
{
	public class Colaborador : Pessoa
	{
		public int IdColaborador { get; private set; }
		public string Funcao { get; set; }
		public double Vencimento { get; set; }
		public string Password { get; private set; }
		public int Equipa { get; set; }
        public List<Colaborador> Colaboradores { get; set; }

		public Colaborador ()
		{ }


        public Colaborador(string nome, Genero genero, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, string password, int equipa)
				: base(nome, genero, contacto, morada, concelho, email)
		{
			IdColaborador = idColaborador;
			Funcao = funcao;
			Vencimento = vencimento;
			Password = password;
			Equipa = equipa;

        }

        //métodos
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

        public bool Autenticar(string funcao, string email, string password)
        {
            return Funcao == funcao && Email == email && Password == password;
        }

        public virtual void AcessoPermitido()
		{
			Console.WriteLine("Bem-vindo/a " + this.Nome);
			Console.WriteLine();
		}

		
        public int TotConsultas()
		{
			return Consulta.Consultas.Count; // conta total das consultas na lista de consultas
		}

        public Dictionary<string, int> ConsDia(Utente utente)
        {
            Dictionary<string, int> contadorEquipas = new Dictionary<string, int>();

            foreach (Consulta consulta in Consulta.Consultas)
            {
                string equipa = consulta.Equipa.ToString();

                if (contadorEquipas.ContainsKey(equipa))
                {
                    contadorEquipas[equipa]++;
                }
                else
                {
                    contadorEquipas[equipa] = 1;
                }
            }

            return contadorEquipas;
        }

        public void RelConsultas()
		{
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("DGS - Direção Regional de Saude de Rastreios");
			Console.WriteLine();
			Console.WriteLine("Relatório Diário de Rastreios");
			Console.WriteLine("Data: " + DateTime.Now.ToString("dd/MM/yyyy"));
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("$Numero Total de Consultas Realizadas: {totalConcultas} ");
			Console.WriteLine("$Numero de consultas realizadas por equipa: {ConsDia} ");
			Console.WriteLine();
			/*Console.WriteLine("Análise de Risco de Tensão Arterial dos Utentes");
			Console.WriteLine("Numero de Utentes com Indice HTA grau I: " + //aplicar .Count para contar o numero de utentes com indice HTA grau I);
			Console.WriteLine("Utentes com Indice HTA grau I: " + //Imprimir os utentes com indice HTA grau I);
			Console.WriteLine("Numero de Utentes com Indice HTA grau II: " + //aplicar .Count para contar o numero de utentes com indice HTA grau II);
			Console.WriteLine("Utentes com Indice HTA grau II: " + //Imprimir os utentes com indice HTA grau II);
			Console.WriteLine("Numero de Utentes com Indice HTA grau III: " + //aplicar .Count para contar o numero de utentes com indice HTA grau III);
			Console.WriteLine("Utentes com Indice HTA grau III: " + //Imprimir os utentes com indice HTA grau III);
			Console.WriteLine();
			Console.WriteLine("Análise de Risco de Diabetes dos Utentes");
			Console.WriteLine("Numero de Utentes com Indice Diabetes grau I: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau I);
			Console.WriteLine("Utentes com Indice Diabetes grau I: " + //Imprimir os utentes com Diabetes grau I);
			Console.WriteLine("Numero de Utentes com Indice Diabetes grau II: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau II);
			Console.WriteLine("Utentes com Indice Diabetes grau II: " + //Imprimir os utentes com Diabetes grau II);
			Console.WriteLine("Numero de Utentes com Indice Diabetes grau III: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau III);
			Console.WriteLine("Utentes com Indice Diabetes grau III: " + //Imprimir os utentes com Diabetes grau III);
			Console.WriteLine();
			Console.WriteLine("Análise de Risco de Obesidade dos Utentes");
			Console.WriteLine("Numero de Utentes com Indice Obesidade grau I " + //aplicar .Count para contar o numero de utentes com indice Obesidade grau I);
			Console.WriteLine("Utentes com Indice Obesidade Grau I: " + //Imprimir os utentes com Obesidade grau I);
			Console.WriteLine("Numero de Utentes com Indice Obesidade grau II " + //aplicar .Count para contar o numero de utentes com indice Obesidade grau II);
			Console.WriteLine("Utentes com Indice Obesidade grau II: " + //Imprimir os utentes com Diabetes grau II);
			Console.WriteLine("-------------------------------------------------"


		*/
		}

		
	}
}

	
	


