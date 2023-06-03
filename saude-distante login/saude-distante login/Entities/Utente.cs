using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace saude_distante_login.Entities
{
    internal class Utente : Pessoa
    {
       public int Idsns { get; set; }
        public bool Yes_Rgpd { get; set; } // true = aceita, false = não aceita

        public List<Utente> utentes { get; set; }

        
        public Utente(string nome, Genero genero, DateTime dataNascimento,string contacto , string morada, Distrito distrito, string email, int id, bool yes_rgpd)
        :base(nome, genero, dataNascimento, contacto, morada, distrito, email)
        {
            Idsns = id;

            Yes_Rgpd = yes_rgpd;

            Utentes = new List<Utente>();

        } 
       

    // Métodos

        public void MostrarDadosUtente()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento}");
            Console.WriteLine($"Telefone: {Contacto}");
            Console.WriteLine($"Morada: {Morada}");
            Console.WriteLine($"Distrito de Residência: {Distrito}");
            Console.WriteLine($"ID SNS: {Idsns}");
            Console.WriteLine($"RGPD: {Yes_Rgpd}");

        }
    }

}
