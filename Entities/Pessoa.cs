﻿using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    public class Pessoa

    {
        public string Nome { get; set; }
        public Genero Genero { get; set; }
        public string Contacto { get; set; }
        public string Morada { get; set; }
        public Concelho Concelho { get; set; }
        public string Email { get; set; }


        //Construtores

        public Pessoa()
        { }

        public Pessoa(string nome, Genero genero, string contacto, string morada, Concelho concelho, string email)
        {
            Nome = nome;
            Genero = genero;
            Contacto = contacto;
            Morada = morada;
            Concelho = concelho;
            Email = email;
        }
    }
}
