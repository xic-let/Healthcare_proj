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
			Console.WriteLine("Análise de Risco de Tensão Arterial dos Utentes");
			Console.WriteLine("Numero de Utentes com Indice HTA grau I: "  +  
			Console.WriteLine("Utentes com Indice HTA grau I: " + 
			Console.WriteLine("Numero de Utentes com Indice HTA grau II: " +
			Console.WriteLine("Utentes com Indice HTA grau II: " + 
			Console.WriteLine("Numero de Utentes com Indice HTA grau III: " + 
			Console.WriteLine("Utentes com Indice HTA grau III: " +
			Console.WriteLine();
			Console.WriteLine("Análise de Risco de Diabetes dos Utentes");
			Console.WriteLine("Numero de Utentes com Indice Diabetes grau I: " + 
			Console.WriteLine("Utentes com Indice Diabetes grau I: " +
			Console.WriteLine("Numero de Utentes com Indice Diabetes grau II: " + 
			Console.WriteLine("Utentes com Indice Diabetes grau II: " + 
			Console.WriteLine("Numero de Utentes com Indice Diabetes grau III: " + 
			Console.WriteLine("Utentes com Indice Diabetes grau III: " + 
			Console.WriteLine();
			Console.WriteLine("Análise de Risco de Obesidade dos Utentes");
			Console.WriteLine("Numero de Utentes com Indice Obesidade grau I " + 
			Console.WriteLine("Utentes com Indice Obesidade Grau I: " + 
			Console.WriteLine("Numero de Utentes com Indice Obesidade grau II " + 
			Console.WriteLine("Utentes com Indice Obesidade grau II: " + 
			Console.WriteLine("-------------------------------------------------");

		}

		
	}
}

	
	


