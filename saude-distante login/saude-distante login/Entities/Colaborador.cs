using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    internal class Colaborador : Pessoa
    {
        public int IdColaborador { get; private set; }
        public Equipa Equipa { get; set; }

        public funcaoProfissional TipoColab { get; set; }
        public double Vencimento { get; set; }

        public string Password { get; private set; }

        public Colaborador()
        {

        }

        public Colaborador(funcaoProfissional tipoColab, string email, string password)
            : base(email)
        {
            TipoColab = tipoColab;
            Password = password;
        }

        public Colaborador(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, Equipa equipa, funcaoProfissional tipoColab, double vencimento, string password)
            : base(nome, genero, dataNascimento, contacto, morada, concelho, email)
        {
            Equipa = equipa;
            IdColaborador = idColaborador;
            TipoColab = tipoColab;
            Vencimento = vencimento;
            Password = password;
        }


        
    }
}
