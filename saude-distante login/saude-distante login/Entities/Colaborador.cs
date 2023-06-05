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
        public double Vencimento { get; set; }
        public string Password { get; private set; }
        public Equipa Equipa { get; set; }
        public List<Equipa> Equipas { get; set; } = new List<Equipa>();

        public Colaborador()
        {

        }

        
        public Colaborador(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, double vencimento, Equipa equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, concelho, email)
        {
            IdColaborador = idColaborador;
            Vencimento = vencimento;
            Equipa = equipa;
            Password = password;
        }

        //Métodos da classe Colaborador
        public virtual void AcessoPermitido()
        {
            Console.WriteLine("Bem-vindo/a " + this.Nome);
            Console.WriteLine();
        }


    }
}
