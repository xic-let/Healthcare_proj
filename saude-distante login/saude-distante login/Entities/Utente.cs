using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace saude_distante_login.Entities
{
	public class Utente : Pessoa
	{
	   
		public int Idsns { get; set; }
		public bool Yes_Rgpd { get; set; } // true = aceita, false = não aceita
		public static List<Utente> Utentes { get; set; } = new List<Utente>();
		public Consulta Consulta { get; set; }
        public static List<Consulta> Consultas { get;} = new List<Consulta>();

		public Utente ()
		{ }


        public Utente(string nome, Genero genero,string contacto, string morada, Concelho concelho, string email, int id, bool yes_rgpd)
		: base(nome, genero, contacto, morada, concelho, email)
		{
			Idsns = id;
			Yes_Rgpd = yes_rgpd;

        }

		public static void RelConsultaInd(List<Utente> utentes, List<Consulta> consultas)
		{
			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine("Relatório da consulta:");
			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine("ID do Utente:");
			int id = int.Parse(Console.ReadLine());

			// Procurar o utente na lista de utentes
			Utente utente = utentes.Find(u => u.Idsns == id);

			if (utente != null)
			{
				Console.WriteLine("Dados do Utente:");
				Console.WriteLine($"Nome: {utente.Nome}");
				Console.WriteLine($"Género: {utente.Genero}");
				Console.WriteLine($"Contacto: {utente.Contacto}");
				Console.WriteLine($"Morada: {utente.Morada}");
				Console.WriteLine($"Distrito: {utente.Concelho}");
				Console.WriteLine($"Email: {utente.Email}");
				Console.WriteLine($"ID: {utente.Idsns}");
				Console.WriteLine($"RGPD: {utente.Yes_Rgpd}");

                // Verificar se o utente possui consultas
                Consulta consulta = consultas.Find(u => u.Idsns == id);
                if (consulta != null)
				{
					Console.WriteLine("Dados da Consulta:");

					// Iterar sobre as consultas do utente
					foreach (Consulta cons in Consulta.Consultas) 
					{
						if (cons.Idsns == id)
						{
							Console.WriteLine($"Data da Consulta: {cons.Data.ToShortDateString()}");
							Console.WriteLine($"Equipa: {cons.Equipa}");
							Console.WriteLine($"Peso: {cons.Peso}");
							Console.WriteLine($"Altura: {cons.Altura}");
							Console.WriteLine($"Fumador: {cons.Fumador}");
							Console.WriteLine($"Histórico de Doenças: {cons.HistoricoDoencas}");
							Console.WriteLine($"Nível de Glicose: {cons.NivelGlicose}");
							Console.WriteLine($"Pressão Arterial (Sistólica): {cons.PressaoArterialsis}");
							Console.WriteLine($"Pressão Arterial (Diastólica): {cons.PressaoArterialdia}");
							Console.WriteLine($"Observações: {cons.Observacoes}");
							Console.WriteLine($"Receitas: {cons.Receitas}");
							Console.WriteLine("--------------------------------------------------");
							Console.WriteLine("Análise de Risco do Utente:");
							// Calcular e exibir o IMC do utente
							cons.CalcImc();
							// Verificar se o utente tem diabetes
							cons.GraudeDiabetes();
							// Verificar a classificação da pressão arterial do utente
							cons.MedidasPA();
							Console.WriteLine("--------------------------------------------------");
						}
					}
				}
				else
				{
					Console.WriteLine("O utente não possui consultas registadas.");
				}
			}
			else
			{
				Console.WriteLine("Utente não encontrado.");
			}
		}

/// ////////////////////////////////////////////////////////////
		 public static void RelEstatistico()
			{
				Console.WriteLine("-------------------------------------------------");
				Console.WriteLine("DGS - Direção Regional de Saúde de Rastreios");
				Console.WriteLine();
				Console.WriteLine("Relatório Estatístico de Rastreios");
				Console.WriteLine("Data: " + DateTime.Now.ToString("dd/MM/yyyy"));
				Console.WriteLine("-------------------------------------------------");
				Console.WriteLine("Número Total de Consultas Realizadas: " + Listas.Consultas.Count);
				Console.WriteLine("Número de Consultas da Última Semana: " + ConsultasSemana());
				Console.WriteLine("Número de Consultas do Último Dia: " + ConsultasDia());
				Console.WriteLine();
				Console.WriteLine("-------------------------------------------------");
			}

				public static int ConsultasSemana()
				{
					int cont = 0;
					foreach (Consulta cons in Listas.Consultas)
					{
						if (cons.Data >= DateTime.Now.AddDays(-7))
						{
							cont++;
						}
					}
					return cont;
				}

				public static int ConsultasDia()
				{
					int cont = 0;
					foreach (Consulta cons in Listas.Consultas)
					{
						if (cons.Data == DateTime.Now.AddDays(-1))
						{
							cont++;
						}
					}
					return cont;
				}

    }

}


