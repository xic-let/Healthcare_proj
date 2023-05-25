using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    public class Utilizador
    {
        public string Nome { get; set; }
        public genero genero { get; set; }
        public DateTime dataNascimento { get; set; }
        public string telefone { get; set; } 
        public string morada { get; set; }
        public Concelho concelho { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isColaborador{ get; set; }   // true se for profissional, false se for cliente
        
    
        // Construtor

        public Utilizador()
        {} // Construtor vazio

        public Utilizador(string nome, string email, string password, bool isColaborador, genero generoUtilizador, DateTime dataNascimento, string telefone, string morada, Concelho concelho)
        {
            Nome = nome;
            Email = email;
            Password = password;
            this.isColaborador = isColaborador;
            this.generoUtilizador = generoUtilizador;
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
            this.morada = morada;
            this.concelho = concelho;
        }

        // Métodos
        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"É colaborador: {isColaborador}");
            Console.WriteLine($"Género: {generoUtilizador}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento}");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"Morada: {morada}");
            Console.WriteLine($"Concelho de Residência: {concelho}");


        }   
    }

}