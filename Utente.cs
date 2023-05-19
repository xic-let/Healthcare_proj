using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_DIstante
{
    public class Utente:User
    {
        public int Idsns;
        public enum Concelho;
        public bool Rgpd;

        list <DadosSaude> dadoutente = new.DadosSaude();

        public Utente() { }

        public Utente(int idsns, enum concelho, bool rgpd)
        {
            this.Idsns = idsns;
            this.Concelho = concelho;
            this.Rgpd = rgpd;
        }

    }
}
