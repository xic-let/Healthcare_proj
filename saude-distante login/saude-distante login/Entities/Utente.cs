using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace saude_distante_login.Entities
{
	internal class Utente : Pessoa
	{
	   
	   public int Idsns { get; set; }
	   public bool Yes_Rgpd { get; set; } // true = aceita, false = não aceita

	   public List<Utente> utentes { get; set; }
	   public List<Consulta> Consultas { get; set; }


		public Utente(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int id, bool yes_rgpd)
		: base(nome, genero, dataNascimento, contacto, morada, concelho, email)
		{
			Idsns = id;
			Yes_Rgpd = yes_rgpd;



			/*Consultas = new List<Consulta>();


            Consultas.Add(new Consulta(new DateTime(20 - 05 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 1,));
			Consultas.Add(new Consulta(new DateTime(20 - 05 - 2023), 2, 65, 1.62, true, "N/A", 85, 122, 90, "N/A", "N/A", 2));
			Consultas.Add(new Consulta(new DateTime(27 - 05 - 2023), 3, 95, 1.85, false, "N/A", 81, 119, 82, "N/A", "Artovastatina", 3));
			Consultas.Add(new Consulta(new DateTime(27 - 05 - 2023), 2, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 4));
			Consultas.Add(new Consulta(new DateTime(01 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina",5));
			Consultas.Add(new Consulta(new DateTime(02 - 06 - 2023), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 6));
			Consultas.Add(new Consulta(new DateTime(05 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 7));
			Consultas.Add(new Consulta(new DateTime(05 - 06 - 2023), 2, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Artovastatina", 8));
			Consultas.Add(new Consulta(new DateTime(05 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 9));
			Consultas.Add(new Consulta(new DateTime(06 - 06 - 2023), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 10));
			Consultas.Add(new Consulta(new DateTime(07 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 11));
			Consultas.Add(new Consulta(new DateTime(08 - 06 - 2023), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 12));
			Consultas.Add(new Consulta(new DateTime(08 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 13));
   */



            utentes = new List<Utente>();
            

            utentes.Add(new Utente("João Silva", Genero.Masculino, new DateTime(06 - 06 - 1975), "123-456-7890", "Rua Sá de Noronha", Concelho.Braga, "joao.silva@example.com", 1, true));
			utentes.Add(new Utente("Maria Santos", Genero.Feminino, new DateTime(02 - 02 - 1980), "987-654-3210", "Avenida da República", Concelho.Amares, "maria.santos@example.com", 2, true));
			utentes.Add(new Utente("Pedro Costa", Genero.Masculino, new DateTime(05 - 05 - 1985), "098-765-4321", "Rua Augusta", Concelho.Guimarães, "pedro.costa@example.com", 3, true));
			utentes.Add(new Utente("Ana Martins", Genero.Feminino, new DateTime(01 - 01 - 1955), "123-456-7891", "Rua Almirante Reis", Concelho.Amares, "ana.martins@example.com", 4, true));
			utentes.Add(new Utente("Bruno Ferreira", Genero.Masculino, new DateTime(02 - 02 - 1960), "987-654-3211", "Rua de Santa Cruz", Concelho.Braga, "bruno.ferreira@example.com", 5, true));
			utentes.Add(new Utente("Carolina Gomes", Genero.Feminino, new DateTime(03 - 03 - 1965), "098-765-4322", "Avenida Central", Concelho.Guimarães, "carolina.gomes@example.com", 6, true));
			utentes.Add(new Utente("Daniel Pereira", Genero.Masculino, new DateTime(04 - 04 - 1969), "123-456-7892", "Rua do Carmo", Concelho.Braga, "daniel.pereira@example.com", 7, true));
			utentes.Add(new Utente("Eva Rodrigues", Genero.Feminino, new DateTime(05 - 05 - 1970), "987-654-3212", "Rua Garrett", Concelho.Amares, "eva.rodrigues@example.com", 8, true));
			utentes.Add(new Utente("Fábio Fernandes", Genero.Masculino, new DateTime(02 - 02 - 1950), "098-765-4323", "Rua de Santa Catarina", Concelho.Braga, "fabio.fernandes@example.com", 9, true));
			utentes.Add(new Utente("Gabriela Lopes", Genero.Feminino, new DateTime(07 - 07 - 1951), "123-456-7893", "Rua da Sofia", Concelho.Guimarães, "gabriela.lopes@example.com", 10, true));
			utentes.Add(new Utente("Hugo Sousa", Genero.Masculino, new DateTime(08 - 08 - 1954), "987-654-3213", "Avenida da Liberdade", Concelho.Braga, "hugo.sousa@example.com", 11, false));
			utentes.Add(new Utente("Inês Almeida", Genero.Feminino, new DateTime(09 - 09 - 1962), "098-765-4324", "Rua das Flores", Concelho.Guimarães, "ines.almeida@example.com", 12, true));
			utentes.Add(new Utente("Joaquim Ribeiro", Genero.Masculino, new DateTime(10 - 10 - 1964), "123-456-7894", "Rua do Rosário", Concelho.Braga, "joaquim.ribeiro@example.com", 13, true));
		}

		public void RelConsultaInd()
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
				Console.WriteLine($"Data de Nascimento: {utente.DataNascimento.ToShortDateString()}");
				Console.WriteLine($"Contacto: {utente.Contacto}");
				Console.WriteLine($"Morada: {utente.Morada}");
				Console.WriteLine($"Distrito: {utente.Concelho}");
				Console.WriteLine($"Email: {utente.Email}");
				Console.WriteLine($"ID: {utente.Idsns}");
				Console.WriteLine($"RGPD: {utente.Yes_Rgpd}");

				// Verificar se o utente possui consultas
				if (utente.Consultas.Count > 0)
				{
					Console.WriteLine("Dados da Consulta:");

					// Iterar sobre as consultas do utente
					foreach (Consulta consulta in utente.Consultas)
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


	}

}


