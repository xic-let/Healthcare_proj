using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    public class Utente : Utilizador
    {
        public int Idsns { get; private set; }
        public bool Yes_Rgpd { get; set; } // true = aceita, false = não aceita
        public List<Consulta> dadossaude{ get; set; }
        
    }

    public Utente()
    { } // Construtor vazio

    public Utente(string nome, genero genero, DateTime dataNascimento,string telefone , string morada, Concelho concelho, string email, string password, int id, bool yes_rgpd)
    :base (nome, email, password, dataNascimento, morada, contacto, false, dadossaude)
    {
        this.Idsns = id;
        this.Yes_Rgpd = yes_rgpd;
        dadossaude = new List<Consulta>();
    }

    public Utente()
    { 
        dadossaude = new List<Consulta>();
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
        Console.WriteLine($"ID SNS: {Idsns}");
        Console.WriteLine($"RGPD: {Yes_Rgpd}");
    }
}