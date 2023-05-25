using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    public class Consulta : Utente
    {
        public DateTime data { get; set; }
        public string hora { get; set; }
        public Concelho concelho { get; set; }
        public Medico medico { get; set; }
        public Enfermeiro enfermeiro { get; set; }
         public double Peso { get; set; }
        public double Altura { get; set; }
        public bool Fumador { get; set; }
        public string HistoricoDoencas { get; set; }
        public double NivelGlicose { get; set; }
        public double PressaoArterialsis { get; set; }
        public double PressaoArterialdia { get; set; }
        public string observacoes { get; set; }

        public Consulta()
        { } // Construtor vazio

        public Consulta(int idsns, bool yes_rgpd, DateTime data, string hora, Concelho concelho, Medico medico, Enfermeiro enfermeiro, double peso, double altura, bool fumador, string historicoDoencas, double nivelGlicose, double pressaoArterialsis, double pressaoArterialdia, string observacoes)
        :base (idsns, yes_rgpd) //falta inserir os dados Utilizador base - ver como fazer
        {
            this.Idsns = idsns;
            this.Yes_Rgpd = yes_rgpd;
            this.data = data;
            this.hora = hora;
            this.concelho = concelho;
            this.medico = medico;
            this.enfermeiro = enfermeiro;
            this.Peso = peso;
            this.Altura = altura;
            this.Fumador = fumador;
            this.HistoricoDoencas = historicoDoencas;
            this.NivelGlicose = nivelGlicose;
            this.PressaoArterialsis = pressaoArterialsis;
            this.PressaoArterialdia = pressaoArterialdia;
            this.observacoes = observacoes;
        }

        public Consulta(DateTime data, string hora, Concelho concelho, string observacoes, Medico medico, Enfermeiro enfermeiro)
        {
            this.data = data;
            this.hora = hora;
            this.concelho = concelho;
            this.observacoes = observacoes;
            this.medico = medico;
            this.enfermeiro = enfermeiro;
        }

        // Métodos
    }

}