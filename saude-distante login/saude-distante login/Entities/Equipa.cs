using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace saude_distante_login.Entities
{
	internal class Equipa
	{

		//Propriedades da classe Equipa
		public int IdEquipa { get; set; }
		public Concelho Concelho { get; }
		public Administrativo Administrativo { get; set; }
		public Motorista Motorista { get; set; }
		public Medico Medico { get; set; }
		public Enfermeiro Enfermeiro { get; set; }
		public List<Equipamentos> Material { get; }
		public List<Colaborador> Colaboradores { get; set; }

		public List<Equipa> Equipas { get; set; }

        //Construtores da classe Equipa

        public Equipa(int idEquipa, Concelho concelho, Administrativo administrativo, Motorista motorista, Medico medico, Enfermeiro enfermeiro, Equipamentos equipamentos, List<Colaborador> colaboradores)
        {
            IdEquipa = idEquipa;
            Administrativo = administrativo;
            Motorista = motorista;
            Medico = medico;
            Enfermeiro = enfermeiro;
            Colaboradores = colaboradores;
        }


        public void AddEquipa()
			{
				Console.WriteLine("Insira o ID da equipa: ");
				int idEquipa = int.Parse(Console.ReadLine());
				Console.WriteLine("Insira o Concelho: ");
				string concelho = Console.ReadLine();
				Console.WriteLine("Insira o nome do administrativo: ");
				string nomeAdministrativo = Console.ReadLine();
				Console.WriteLine("Insira o nome do motorista: ");
				string nomeMotorista = Console.ReadLine();
				Console.WriteLine("Insira o nome do médico: ");
				string nomeMedico = Console.ReadLine();
				Console.WriteLine("Insira o nome do enfermeiro: ");
				string nomeEnfermeiro = Console.ReadLine();
				Console.WriteLine("Equipa Criada Com Sucesso!");
				Console.WriteLine("Inventario de Equipamentos Atribuido!");
				Console.WriteLine(Equipamentos.Inventario());

				Equipa equipa = new Equipa(idEquipa, concelho, nomeAdministrativo, nomeMotorista, nomeMedico, nomeEnfermeiro);

			
			}
	}
}


