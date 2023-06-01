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
        public Concelho Concelho { get; set; }
        public Administrativo Administrativo { get; set; }
        public Motorista Motorista { get; set; }
        public Medico Medico { get; set; }
        public Enfermeiro Enfermeiro { get; set; }

        //Construtores da classe Equipa
        public Equipa()
        {
        }

        public Equipa(int idEquipa, Concelho concelho, Administrativo administrativo, Motorista motorista, List<Medico> medicos, List<Enfermeiro> enfermeiros)
        {
            IdEquipa = idEquipa;
            Concelho = concelho;
            Administrativo = administrativo;
            Motorista = motorista;
            Medico = medicos;
            Enfermeiro = enfermeiros;
        }
    }
}

