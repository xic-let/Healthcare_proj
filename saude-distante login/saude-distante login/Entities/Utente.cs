using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    internal class Utente : Pessoa
    {
        public int IDSNS { get; set; }
        public bool Sim_RGPD { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public bool Fumador { get; set; }
        public string HistoricoDoencas { get; set; }
        public double NivelGlicose { get; set; }
        public double PressaoArterialSis { get; set; }
        public double PressaoArterialDia { get; set; }
        public string Observacoes { get; set; }


        public Utente()
        {

        }

        public Utente(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Distrito distrito, string email, int idSNS, bool sim_RGPD, double peso, double altura, bool fumador, string historicoDoencas, double nivelGlicose, double pressaoArterialSis, double pressaoArterialDia, string observacoes)
            : base(nome, genero, dataNascimento, contacto, morada, distrito, email)
        {
            IDSNS = idSNS;
            Sim_RGPD = sim_RGPD;
            Peso = peso;
            Altura = altura;
            Fumador = fumador;
            HistoricoDoencas = historicoDoencas;
            NivelGlicose = nivelGlicose;
            PressaoArterialSis = pressaoArterialSis;
            PressaoArterialDia = pressaoArterialDia;
            Observacoes = observacoes;
        }


    }
}
