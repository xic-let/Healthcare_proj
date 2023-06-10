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
		public string? Funcao { get; set; }
		public double Vencimento { get; set; }
		public string? Password { get; private set; }
		public int Equipa { get; set; }
		public List<Colaborador>? Colaboradores { get; set; }

		public Colaborador()
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

		public int TotConsultas()
		{
			return Listas.Consultas.Count; // conta total das consultas na lista de consultas
		}


		public void RelConsultas()
		{
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("DGS - Direção Regional de Saúde de Rastreios");
			Console.WriteLine();
			Console.WriteLine("Relatório Diário de Rastreios");
			Console.WriteLine("Data: " + DateTime.Now.ToString("dd/MM/yyyy"));
			Console.WriteLine("-------------------------------------------------");

			Console.WriteLine("Análise de Risco dos Utentes");

			Console.WriteLine($"Número Total de Consultas Realizadas: " + TotConsultas());
			Console.WriteLine($"Número de Consultas Realizadas por Equipa: " + NrConsultasPorEquipa());
			Console.WriteLine();

			Console.WriteLine("Análise de Risco de Tensão Arterial dos Utentes");

			List<Consulta> consultas = Consulta.Consultas;
			int nrHTA1 = NrUtentesCondicao(consultas);
			Console.WriteLine("Número de Utentes com Índice HTA Grau I: " + nrHTA1);

			int nrHTA2 = NrUtentesCondicao2(consultas);
			Console.WriteLine("Número de Utentes com Índice HTA Grau II: " + nrHTA2);
			
			int nrHTA3 = NrUtentesCondicao3(consultas);
			Console.WriteLine("Número de Utentes com Índice HTA Grau III: " + nrHTA3);
			
			Console.WriteLine();

			int diabetes1 = DiabetesGrauI(consultas);
			Console.WriteLine("Número de Utentes com Índice Diabetes Grau I: " + diabetes1);
			
			Console.WriteLine("Análise de Risco de Diabetes dos Utentes");
			int diabetes2 = DiabetesGrauI(consultas);
			Console.WriteLine("Número de Utentes com Índice Diabetes Grau II: " + diabetes2);

			int diabetes3 = DiabetesGrauI(consultas);
			Console.WriteLine("Número de Utentes com Índice Diabetes Grau III: " + diabetes3);
			

			Console.WriteLine();

			Console.WriteLine("Análise de Risco de Obesidade dos Utentes");
			int obesidade1 = ObesidadeGrauI();
			Console.WriteLine("Número de Utentes com Índice Obesidade Grau I: " + obesidade1);

			int obesidade2 = ObesidadeGrauII();
			Console.WriteLine("Número de Utentes com Índice Obesidade Grau II: " + obesidade2);

			int obesidade3 = ObesidadeGrauIII();
			Console.WriteLine("Número de Utentes com Índice Obesidade Grau III: " + obesidade3);
			
			
			Console.WriteLine("-------------------------------------------------");
		}


        public int NrConsultasPorEquipa()
        {
            Dictionary<int, int> consultasPorEquipa = new Dictionary<int, int>();

            foreach (Consulta consulta in Listas.Consultas)
            {
                if (consultasPorEquipa.ContainsKey(consulta.Equipa))
                {
                    consultasPorEquipa[consulta.Equipa]++;
                }
                else
                {
                    consultasPorEquipa[consulta.Equipa] = 1;
                }
            }
            foreach (KeyValuePair<int, int> equipe in consultasPorEquipa)
            {
                Console.WriteLine($"Equipa {equipe.Key}: {equipe.Value} consultas");
            }

            return Consulta.Consultas.Count;

        }

        public int NrUtentesCondicao(List<Consulta> consultas)
		{
			int contaHTA1 = 0;

			foreach (Consulta consulta in Listas.Consultas)
			{
				if ((consulta.PressaoArterialsis > 139 && consulta.PressaoArterialsis < 160) || (consulta.PressaoArterialdia > 89 && consulta.PressaoArterialdia < 100))
				{
					contaHTA1++;
				}
			}
			return contaHTA1;

		}

		public int NrUtentesCondicao2(List<Consulta> consultas)
		{
			int contaHTA2 = 0;

			foreach (Consulta consulta in Listas.Consultas)
			{
				if ((consulta.PressaoArterialsis > 160 && consulta.PressaoArterialsis < 180) || (consulta.PressaoArterialdia > 99 && consulta.PressaoArterialdia < 110))
				{
					contaHTA2++;
				}
			}
			return contaHTA2;

		}

		public int NrUtentesCondicao3(List<Consulta> consultas)
		{
			int contaHTA3 = 0;

			foreach (Consulta consulta in Listas.Consultas)
			{
				if (consulta.PressaoArterialsis > 180 || consulta.PressaoArterialdia < 110)
				{
					contaHTA3++;
				}
			}
			return contaHTA3;

		}

	
		public int DiabetesGrauI(List<Consulta> consultas)
		{
			int i = 0;

			foreach (Consulta consulta in Listas.Consultas)
			{
				if (consulta.NivelGlicose < 100)
				{
					i++;
				}
			}
			return i;

		}

		public int DiabetesGrauII(List<Consulta> consultas)
		{
			int i = 0;

			foreach (Consulta consulta in Listas.Consultas)
			{
				if (consulta.NivelGlicose <= 125)
				{
					i++;
				}
			}
			return i;

		}

		public int DiabetesGrauIII(List<Consulta> consultas)
		{
			int i = 0;

			foreach (Consulta consulta in Listas.Consultas)
			{
				if (consulta.NivelGlicose > 125)
				{
					i++;
				}
			}
			return i;

		}


		public int ObesidadeGrauI()
		{
			int i = 0;

			foreach (Consulta consulta in Listas.Consultas)
			{
				double imc = consulta.Peso / (consulta.Altura * consulta.Altura);
				if (imc > 30 && imc <= 34.9)
				{
					i++;
				}
			}
			return i;

		}

		public int ObesidadeGrauII()
		{
			int i = 0;

			foreach (Consulta consulta in Listas.Consultas)
			{
				double imc = consulta.Peso / (consulta.Altura * consulta.Altura);
				if (imc >= 35 && imc <= 39.9)
				{
					i++;
				}
			}
			return i;
		}

		public int ObesidadeGrauIII()
		{
		int i = 0;

		foreach (Consulta consulta in Listas.Consultas)
		{
			double imc = consulta.Peso / (consulta.Altura * consulta.Altura);
			if (imc >= 40)
			{
				i++;
			}
		}
		return i;

		}
	}
}

	
	


