using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    public class Colaborador : Utilizador
    {
        // Atributos
        public int IdColaborador { get; set; }
        public object cargo { get; internal set; }
        public string Password { get; set; }
        public double salario { get; private set; }

        // Construtor

        public Colaborador (string nome, genero genero, DateTime dataNascimento,string telefone , string morada, Concelho concelho, string email, string password, int idColaborador) 
        :base(nome, email, dataNascimento, morada, contacto)
            {
                this.IdColaborador = idColaborador;
                this.funcaoProfissional = funcaoProfissional;
                definirColaborador();
            }



        // Métodos
       consultaRelUtentes()
       {
           // TODO
       }    
       ConsultaDadosDiarios()
       {
           // TODO
       }
    }
}