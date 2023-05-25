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
        public FuncaoProfissional funcaoProfissional { get; set; }
        public object cargo { get; internal set; } // FunçãoProfissional é um enum, mas como não podemos herdar de um enum, temos de usar um object para guardar o valor do enum

        // Construtor
        public Colaborador()
        { } // Construtor vazio

        public Colaborador (string nome, genero genero, DateTime dataNascimento,string telefone , string morada, Concelho concelho, string email, string password, FuncaoProfissional funcaoProfissional, int idColaborador) 
        :base(nome, email, password, dataNascimento, morada, contacto, true)
            {
                this.IdColaborador = idColaborador;
                this.funcaoProfissional = funcaoProfissional;
                definirColaborador();
            }



        // Métodos
        public void definirColaborador() // Função que define o cargo do colaborador
        {
            switch (FunçãoProfissional)
            {
                case FuncaoProfissional.Médico:
                    cargo = new Medico();
                    break;
                case FuncaoProfissional.Enfermeiro:
                    cargo = new Enfermeiro();
                    break;
                case FuncaoProfissional.Administrativo:
                    cargo = new Administrativo();
                    break;
                case FuncaoProfissional.Motorista:
                    cargo = new Motorista();
                    break;
                default:
                    Console.WriteLine("Função inválida");
                    break;
            }
        }
    }
}