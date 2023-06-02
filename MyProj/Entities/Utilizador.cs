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
        public Genero GeneroUtil { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; } 
        public string Morada { get; set; }
        public Concelho ConcelhoUtil { get; set; }
        public string Email { get; set; }
<<<<<<< Updated upstream
=======
        
        
>>>>>>> Stashed changes
        
    
        // Construtor

        public Utilizador()
        {} // Construtor vazio

        public Utilizador(string nome, string email, Genero generoUtil, DateTime dataNascimento, string telefone, string morada, Concelho concelhoUtil)
        {
            Nome = nome;
            Email = email;
<<<<<<< Updated upstream
            this.generoUtilizador = generoUtilizador;
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
            this.morada = morada;
            this.concelho = concelho;
=======
            GeneroUtil = generoUtil;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Morada = morada;
            Concelho = concelhoUtil;
>>>>>>> Stashed changes
        }

        // Métodos
        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Género: {generoUtilizador}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento}");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"Morada: {morada}");
            Console.WriteLine($"Concelho de Residência: {concelho}");


        }   
    }

}