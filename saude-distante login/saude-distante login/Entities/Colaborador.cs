using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

List<Colaborador> colaboradores = new List<Colaborador>();



namespace saude_distante_login.Entities
{
	public class Colaborador : Pessoa
	{
		public int IdColaborador { get; private set; }
		public string Funcao { get; set; }
		public double Vencimento { get; set; }
		public string Password { get; private set; }
		public int Equipa { get; set; }

		List<Colaborador> colaboradores = new List<Colaborador>();


		public Colaborador(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, string password, int equipa)
				: base(nome, genero, dataNascimento, contacto, morada, concelho, email)
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
            List<Colaborador> colaboradores = new List<Colaborador>();
            int x;
			for (x = 0; x < colaboradores.Count; x++)
			{	
				Console.WriteLine("Lista de Colaboradores: ");
				Console.WriteLine("Nome: ");
				Console.WriteLine(colaboradores[x].Nome);	
				Console.WriteLine("Vencimento em €:");
				Console.WriteLine(colaboradores[x].Vencimento);
				Console.WriteLine("Função: ");
				Console.WriteLine(colaboradores[x].Funcao);
				Console.WriteLine("Equipa: ");
				Console.WriteLine(colaboradores[x].Equipa);
			}
		}

		public void loadlist()
		{
			
            colaboradores.Add(new Colaborador("Maria José", Genero.Feminino, new DateTime(11 - 11 - 1987), "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, "123456", 1));
            colaboradores.Add(new Colaborador("Maria José", Genero.Feminino, new DateTime(11 - 11 - 1987), "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, "123456", 2));
            colaboradores.Add(new Colaborador("Maria José", Genero.Feminino, new DateTime(11 - 11 - 1987), "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, "123456", 3));
            colaboradores.Add(new Colaborador("Manuel Pires", Genero.Masculino, new DateTime(12 - 12 - 1977), "918302038", "Rua Velha", Concelho.Amares, "manuel.pires@email.com", 124, "Motorista", 1100, "123456", 2));
            colaboradores.Add(new Colaborador("Andreia Gomes", Genero.Feminino, new DateTime(01 - 01 - 1979), "918312338", "Rua Antiga", Concelho.Amares, "andreia.gomes@email.com", 125, "Médico", 1800, "123456", 2));
            colaboradores.Add(new Colaborador("João Silva", Genero.Masculino, new DateTime(12 - 12 - 1990), "918302658", "Rua da Alegria", Concelho.Amares, "joao.silva@email.com", 126, "Enfermeiro", 1500, "123456", 2));
            colaboradores.Add(new Colaborador("Soraia Pereira", Genero.Feminino, new DateTime(01 - 01 - 1969), "918319827", "Rua 25 de Abril", Concelho.Braga, "soraia.pereira@email.com", 127, "Motorista", 1100, "123456", 1));
            colaboradores.Add(new Colaborador("André Souto", Genero.Masculino, new DateTime(02 - 02 - 1979), "915555666", "Rua Milenar", Concelho.Braga, "andre.souto@email.com", 128, "Médico", 2000, "123456", 1));
            colaboradores.Add(new Colaborador("Clara Pinto", Genero.Feminino, new DateTime(03 - 03 - 1991), "967584444", "Rua Direita", Concelho.Braga, "clara.pinto@email.com", 129, "Enfermeiro", 1000, "123456", 1));
            colaboradores.Add(new Colaborador("Miguel Soares", Genero.Masculino, new DateTime(04 - 04 - 1974), "911233454", "Rua 5 de Outubro", Concelho.Guimarães, "miguel.soares@email.com", 130, "Motorista", 1100, "123456", 3));
            colaboradores.Add(new Colaborador("Joana Freitas", Genero.Feminino, new DateTime(05 - 05 - 1988), "918111222", "Rua Velha", Concelho.Guimarães, "joana.freitas@email.com", 131, "Médico", 1500, "123456", 3));
            colaboradores.Add(new Colaborador("Carlos Santos", Genero.Masculino, new DateTime(12 - 12 - 1987), "918891918", "Rua Santa", Concelho.Guimarães, "carlos.santos@email.com", 132, "Enfermeiro", 1500, "123456", 3));
        }

		public void ListarColaboradoresPorEquipa()
		{
			Console.WriteLine("Escolha a equipa: ");
			Console.WriteLine("1 - Equipa 1");
			Console.WriteLine("2 - Equipa 2");
			Console.WriteLine("3 - Equipa 3");
			int opcao = Convert.ToInt32(Console.ReadLine());

            List<Colaborador> colaboradores = new List<Colaborador>();

            if (opcao == 1)
			{
               
                int x;
				for (x = 0; x < colaboradores.Count; x++)
				{
					if (colaboradores[x].Equipa == 1)
					{
						Console.WriteLine("Lista de Colaboradores: ");
						Console.WriteLine("Nome: ");
						Console.WriteLine(colaboradores[x].Nome);
						Console.WriteLine("Vencimento em €:");
						Console.WriteLine(colaboradores[x].Vencimento);
						Console.WriteLine("Função: ");
						Console.WriteLine(colaboradores[x].Funcao);
						Console.WriteLine("Equipa: ");
						Console.WriteLine(colaboradores[x].Equipa);
					}
				}
			}
			else if (opcao == 2)
			{
				int x;
				for (x = 0; x < colaboradores.Count; x++)
				{
					if (colaboradores[x].Equipa == 2)
					{
						Console.WriteLine("Lista de Colaboradores: ");
						Console.WriteLine("Nome: ");
						Console.WriteLine(colaboradores[x].Nome);
						Console.WriteLine("Vencimento em €:");
						Console.WriteLine(colaboradores[x].Vencimento);
						Console.WriteLine("Função: ");
						Console.WriteLine(colaboradores[x].Funcao);
						Console.WriteLine("Equipa: ");
						Console.WriteLine(colaboradores[x].Equipa);
					}
				}
			}
			else if (opcao == 3)
			{
				int x;
				for (x = 0; x < colaboradores.Count; x++)
				{
					if (colaboradores[x].Equipa == 3)
					{
						Console.WriteLine("Lista de Colaboradores: ");
						Console.WriteLine("Nome: ");
						Console.WriteLine(colaboradores[x].Nome);
						Console.WriteLine("Vencimento em €:");
						Console.WriteLine(colaboradores[x].Vencimento);
						Console.WriteLine("Função: ");
						Console.WriteLine(colaboradores[x].Funcao);
						Console.WriteLine("Equipa: ");
						Console.WriteLine(colaboradores[x].Equipa);
					}
				}
			}
		}

        public virtual void AcessoPermitido()
		{
			Console.WriteLine("Bem-vindo/a " + this.Nome);
			Console.WriteLine();
		}

		
        private int TotConsultas(Utente utente)
		{
			return utente.Consultas.Count; // conta total das consultas na lista de consultas
		}

        private Dictionary<string, int> ConsDia(Utente utente)
        {
            Dictionary<string, int> contadorEquipas = new Dictionary<string, int>();

            foreach (Consulta consulta in utente.Consultas)
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

	
	


