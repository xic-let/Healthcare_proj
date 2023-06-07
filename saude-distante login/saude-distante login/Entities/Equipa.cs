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


        
	}
}


