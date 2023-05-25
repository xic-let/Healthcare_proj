using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    public class Medico : Colaborador
    {
        public double salario { get; private set; }
        public Equipa equipa { get; set; }

        public Medico()
        { } // Construtor vazio

    }
}