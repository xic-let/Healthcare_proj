using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Saude_DIstante
{
    public class DadosSaude:Utente
    {
        public int Idade { get; set; } // regista idade
        public float Peso { get; set; } // regista peso
        public float Altura { get; set; } //regista altura
        public string Historico { get; set; } = string.Empty; //regista historico de doenças anteriores
        public bool Fumador { get; set; } // fumador sim ou nao
        public bool Alcool { get; set; } // consome bebidas alcoolicas sim ou nao
        public int Pasis { get; set; } //pressão arterial sistolica
        public int Padia { get; set; } // pressão arterial diastolica
        public float Glicose { get; set; } // regista glicose para mediçao diabetes
        public string Meds { get; set; } = string.Empty; //regista medicação habitual


        public DadosSaude()
        { }

        public DadosSaude(int idade, float peso, float altura, string historico, bool fumador, bool alcool, int pasis, int padia, float glicose, string Meds)
        {
            this.Idade = idade;
            this.Peso = peso;
            this.Altura = altura;
            this.Historico = historico;
            this.Fumador = fumador;
            this.Alcool = alcool;
            this.Pasis = pasis;
            this.Padia = padia;
            this.Glicose = glicose;
            this.Meds = Meds;
        }
    }
}