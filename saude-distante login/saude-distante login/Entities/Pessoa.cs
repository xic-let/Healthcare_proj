using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public Genero Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Contacto { get; set; }
        public string Morada { get; set; }
        public Distrito Distrito { get; set; }
        public string Email { get; set; }


        //Construtores

        public Pessoa()
        {

        }

        public Pessoa(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Distrito distrito, string email)
        {
            Nome = nome;
            Genero = genero;
            DataNascimento = dataNascimento;
            Contacto = contacto;
            Morada = morada;
            Distrito = distrito;
            Email = email;
        }
    }
}
