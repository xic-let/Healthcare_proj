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
	internal class Colaborador : Pessoa
	{
		public int IdColaborador { get; private set; }
		public string Funcao { get; set; }
		public double Vencimento { get; set; }
		public string Password { get; private set; }
		public int Equipa { get; set; }


        public Colaborador(int equipa, string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, string password)
                : base(nome, genero, dataNascimento, contacto, morada, concelho, email)
        {
            IdColaborador = idColaborador;
            Funcao = funcao;
            Vencimento = vencimento;
            Password = password;
            Equipa = equipa;


            List<Colaborador> colaboradores = new List<Colaborador>();

			colaboradores.Add(new Colaborador("Maria José", Genero.Feminino, new DateTime(11 - 11 - 1987), "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, "123456", 1));
			colaboradores.Add(new Colaborador("Maria José", Genero.Feminino, new DateTime(11 - 11 - 1987), "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, "123456", 2));
			colaboradores.Add(new Colaborador("Maria José", Genero.Feminino, new DateTime(11 - 11 - 1987), "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, "123456", 3));
			colaboradores.Add(new Colaborador("Manuel Pires", Genero.Masculino, new DateTime(12 - 12 - 1977), "918302038", "Rua Velha", Concelho.Amares, "manuel.pires@email.com", 124, "Motorista", 1100,"123456", 2));
			colaboradores.Add(new Colaborador("Andreia Gomes", Genero.Feminino, new DateTime(01 - 01 - 1979), "918312338", "Rua Antiga", Concelho.Amares, "andreia.gomes@email.com", 125, "Médico", 1800, "123456", 2));
			colaboradores.Add(new Colaborador("João Silva", Genero.Masculino, new DateTime(12 - 12 - 1990), "918302658", "Rua da Alegria", Concelho.Amares, "joao.silva@email.com", 126, "Enfermeiro", 1500, "123456", 2));
			colaboradores.Add(new Colaborador("Soraia Pereira", Genero.Feminino, new DateTime(01 - 01 - 1969), "918319827", "Rua 25 de Abril", Concelho.Braga, "soraia.pereira@email.com", 127, "Motorista", 1100, "123456", 1));
			colaboradores.Add(new Colaborador("André Souto", Genero.Masculino, new DateTime(02 - 02 - 1979), "915555666", "Rua Milenar", Concelho.Braga, "andre.souto@email.com", 128, "Médico", 2000, "123456", 1));
			colaboradores.Add(new Colaborador("Clara Pinto", Genero.Feminino, new DateTime(03 - 03 - 1991), "967584444", "Rua Direita", Concelho.Braga, "clara.pinto@email.com", 129, "Enfermeiro", 1000, "123456", 1));
			colaboradores.Add(new Colaborador("Miguel Soares", Genero.Masculino, new DateTime(04 - 04 - 1974), "911233454", "Rua 5 de Outubro", Concelho.Guimarães, "miguel.soares@email.com", 130, "Motorista", 1100, "123456", 3));
			colaboradores.Add(new Colaborador("Joana Freitas", Genero.Feminino, new DateTime(05 - 05 - 1988), "918111222", "Rua Velha", Concelho.Guimarães, "joana.freitas@email.com", 131, "Médico", 1500, "123456", 3));
			colaboradores.Add(new Colaborador("Carlos Santos", Genero.Masculino, new DateTime(12 - 12 - 1987), "918891918", "Rua Santa", Concelho.Guimarães, "carlos.santos@email.com", 132, "Enfermeiro", 1500, "123456", 3));


            List<Colaborador> equipa1 = new List<Colaborador>()
            {
                colaboradores[0], // Example: Assigning the first colaborador from the list
				colaboradores[3],
				colaboradores[4],
				colaboradores[5],
				
				
				
				// Example: Assigning the second colaborador from the list
                // Add more colaboradores to the team
            };

			List<Colaborador> equipa2 = new List<Colaborador>()
			{
				 colaboradores[1],
				 colaboradores[6],
				 colaboradores[7],
				 colaboradores[8]
			};


			List<Colaborador> equipa3 = new List<Colaborador>()
			{
				colaboradores[2],
				colaboradores[9],
				colaboradores[10],
				colaboradores[11]
			};


        ////////Métodos da classe Colaborador//////////////////////////////////////////////////////////////////////Colaborad

        public virtual void AcessoPermitido()
		{
			Console.WriteLine("Bem-vindo/a " + this.Nome);
			Console.WriteLine();
		}



		private int TotConsultas(Utente utente)
		{
			return utente.Consultas.Count; // conta total das consultas na lista de consultas
		}

        public override string ToString()
        {
            return "ID: " + IdColaborador
                + "Nome: " + Nome
                + "Funcao: " + Funcao
                + "Equipa: " + Equipa
                + "Vencimento: " + Vencimento;
        }

        private Dictionary<string, int> ConsDia(Utente utente)
        {
            Dictionary<string, int> contadorEquipas = new Dictionary<string, int>();

            foreach (Consulta consulta in utente.Consultas)
            {
                string equipa = consulta.Equipa;

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



		}

		public void RelEstatistico()
		{   
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("DGS - Direção Regional de Saude de Rastreios");
			Console.WriteLine();
			Console.WriteLine("Relatório Estatistico de Rastreios");
			Console.WriteLine("Data: " + DateTime.Now.ToString("dd/MM/yyyy"));
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

		}*/
		}

	}

}
