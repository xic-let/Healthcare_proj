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
        public static List<Consulta> Consultas { get; set; } = new List<Consulta>();

		public Utente ()
		{ }


        public Utente(string nome, Genero genero,string contacto, string morada, Concelho concelho, string email, int id, bool yes_rgpd)
		: base(nome, genero, contacto, morada, concelho, email)
		{
			Idsns = id;
			Yes_Rgpd = yes_rgpd;

        }

		public static void RelConsultaInd()
		{
			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine("Relatório da consulta:");
			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine("ID do Utente:");
			int id = int.Parse(Console.ReadLine());

			// Procurar o utente na lista de utentes
			Utente utente = Utentes.Find(u => u.Idsns == id);

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
                Consulta consulta = Consulta.Consultas.Find(u => u.Utente == utente);
                if (consulta != null)
				{
					Console.WriteLine("Dados da Consulta:");

					// Iterar sobre as consultas do utente
					foreach (Consulta cons in Consulta.Consultas) 
					{
						if (cons.Utente == utente)
						{
							Console.WriteLine($"Data da Consulta: {consulta.Data.ToShortDateString()}");
							Console.WriteLine($"Equipa: {consulta.Equipa}");
							Console.WriteLine($"Peso: {consulta.Peso}");
							Console.WriteLine($"Altura: {consulta.Altura}");
							Console.WriteLine($"Fumador: {consulta.Fumador}");
							Console.WriteLine($"Histórico de Doenças: {consulta.HistoricoDoencas}");
							Console.WriteLine($"Nível de Glicose: {consulta.NivelGlicose}");
							Console.WriteLine($"Pressão Arterial (Sistólica): {consulta.PressaoArterialsis}");
							Console.WriteLine($"Pressão Arterial (Diastólica): {consulta.PressaoArterialdia}");
							Console.WriteLine($"Observações: {consulta.Observacoes}");
							Console.WriteLine($"Receitas: {consulta.Receitas}");
							Console.WriteLine("--------------------------------------------------");
							Console.WriteLine("Análise de Risco do Utente:");
							// Calcular e exibir o IMC do utente
							consulta.CalcImc();
							// Verificar se o utente tem diabetes
							consulta.GraudeDiabetes();
							// Verificar a classificação da pressão arterial do utente
							consulta.MedidasPA();
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
		 public  static void RelEstatistico()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("DGS - Direção Regional de Saude de Rastreios");
            Console.WriteLine();
            Console.WriteLine("Relatório Estatistico de Rastreios");
            /*Console.WriteLine("Data: " + DateTime.Now.ToString("dd/MM/yyyy"));
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("Numero Total de Consultas Realizadas: " + //aplicar .Count para contar o numero de consultas realizadas);
			Console.WriteLine("Numero de consultas realizadas por Rota: " + //sortir as consultas por equipa e contar ccada uma delas);
			Console.WriteLine();
			Console.WriteLine("Análise de Risco de Tensão Arterial dos Utentes");
			Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau I: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau I);
			Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau II: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau II);
			Console.WriteLine("Percentagem de Utentes com Indice HTA grau III: " + //Imprimir os utentes com indice HTA grau III);
			Console.WriteLine();
			Console.WriteLine("Análise de Risco de Diabetes dos Utentes");
			Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau I: " + //Imprimir os utentes com Diabetes grau I);
			Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau II: " + //Imprimir os utentes com Diabetes grau II);
			Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau III: " + //Imprimir os utentes com Diabetes grau III);
			Console.WriteLine();
			Console.WriteLine("Análise de Risco de Obesidade dos Utentes");
			Console.WriteLine("Percentagem  de Utentes com Indice Obesidade grau I " + //aplicar .Count para contar o numero de utentes com indice Obesidade grau I);
			Console.WriteLine("Percentagem de Utentes com Indice Obesidade grau II " + //aplicar .Count para contar o numero de utentes com indice Obesidade grau II);
			Console.WriteLine("-------------------------------------------------"
			*/
        }

    }

}


