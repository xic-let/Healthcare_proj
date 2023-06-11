using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using OfficeOpenXml;
using System.IO;


namespace saude_distante_login.Entities
{
	public class Utente : Pessoa
	{
	   
		public int Idsns { get; set; }
		public bool Yes_Rgpd { get; set; } // true = aceita, false = não aceita
		public static List<Utente> Utentes { get; set; } = new List<Utente>();
		public Consulta? Consulta { get; set; }
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
			Utente utente = Listas.Utentes.Find(u => u.Idsns == id);

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
                Consulta consulta = Listas.Consultas.Find(u => u.Idsns == id);
                if (consulta != null)
				{
					Console.WriteLine("Dados da Consulta:");

					// Iterar sobre as consultas do utente
					foreach (Consulta cons in Listas.Consultas) 
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
				int totalConsultas = Listas.Consultas.Count;
				int consultasSemana = ConsultasSemana();
				int consultasDia = ConsultasDia();
				string Rel_Estatistico = "relatorio_estatistico.xlsx"; // Nome do arquivo Excel


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

				ExportarExcel(totalConsultas, consultasSemana, consultasDia, Rel_Estatistico); // Chama o método para exportar o relatório estatístico para Excel
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

			public static void ExportarExcel(int totalConsultas, int consultasSemana, int consultasDia, string Rel_Estatistico)
			{
				// Cria um novo arquivo Excel
				using (var package = new ExcelPackage())
				{
					// Cria uma planilha no arquivo Excel
					var worksheet = package.Workbook.Worksheets.Add("Relatório Estatístico");

					// Define os cabeçalhos das colunas
					worksheet.Cells[1, 1].Value = "Data";
					worksheet.Cells[1, 2].Value = "Total de Consultas";
					worksheet.Cells[1, 3].Value = "Consultas da Última Semana";
					worksheet.Cells[1, 4].Value = "Consultas do Último Dia";

					// Preenche os dados estatísticos nas células
					worksheet.Cells[2, 1].Value = DateTime.Now.ToString("dd/MM/yyyy");
					worksheet.Cells[2, 2].Value = totalConsultas;
					worksheet.Cells[2, 3].Value = consultasSemana;
					worksheet.Cells[2, 4].Value = consultasDia;

					// Salva o arquivo Excel no disco
					var file = new FileInfo(Rel_Estatistico);
					package.SaveAs(Rel_Estatistico);
				}
			}

    }

}


