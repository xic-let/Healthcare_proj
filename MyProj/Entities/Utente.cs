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

    // Métodos
}