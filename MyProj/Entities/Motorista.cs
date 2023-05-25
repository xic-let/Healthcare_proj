using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    public class Motorista : Colaborador
    {
        public string viatura  { get; private set; }
        public Equipa equipa { get; set; }

        public double salario { get; private set; }

        public Motorista()
        { } // Construtor vazio

        public Motorista()
        //falta inserir os dados do Motorista)
        {
            this.salario = salario;
            this.equipa = equipa;
            this.viatura = viatura;
        }

        //metodos - funcoes do Motorista

    }
}