using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using saude_distante_login.Entities.Enums;

namespace saude_distante_login.Entities
{
   public class Consulta 
                            
    {
        //Propriedades//////////////////////////////////////////
        public DateTime Data { get; set; }
        public int Equipa { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public bool Fumador { get; set; }
        public string HistoricoDoencas { get; set; }
        public double NivelGlicose { get; set; }
        public double PressaoArterialsis { get; set; }
        public double PressaoArterialdia { get; set; }
        public string Observacoes { get; set; }
        public string Receitas { get; set; }
        public int numUtente { get; set; }
        public Utente Utente { get; set; }
        public static List<Consulta> Consultas { get; set; } = new List<Consulta>();
        public DateTime DateTime { get; }
        public int V1 { get; }
        public int V2 { get; }
        public double V3 { get; }
        public bool V4 { get; }
        public string V5 { get; }
        public int V6 { get; }
        public int V7 { get; }
        public int V8 { get; }
        public string V9 { get; }
        public string V10 { get; }
        public int V11 { get; }

        //Construtores////////////////////////////////////////////////////////////////////////////////

        public Consulta() { }

        public Consulta (DateTime data, int equipa, double peso, double altura, bool fumador, string historicoDoencas, double nivelGlicose, double pressaoArterialsis, double pressaoArterialdia, string observacoes, string receitas, int numutente, Utente utente)

        {
            Data = data;
            Equipa = equipa;
            Peso = peso;
            Altura = altura;
            Fumador = fumador;
            HistoricoDoencas = historicoDoencas;
            NivelGlicose = nivelGlicose;
            PressaoArterialsis = pressaoArterialsis;
            PressaoArterialdia = pressaoArterialdia;
            Observacoes = observacoes;
            Receitas = receitas;
            numUtente = numutente;
            Utente = utente;
                      
            
        }

        public Consulta(DateTime data, int equipa, double peso, double altura, double pressaoArterialdia, double pressaoArterialsis, double glicose, Utente utente)
        {
            Data = data;
            Equipa = equipa;
            Peso = peso;
            Altura = altura;
            PressaoArterialdia = pressaoArterialdia;
            PressaoArterialsis = pressaoArterialsis;
            NivelGlicose = glicose;
           
        }

        public Consulta(DateTime dateTime, int v1, int v2, double v3, bool v4, string v5, int v6, int v7, int v8, string v9, string v10, int v11)
        {
            DateTime = dateTime;
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
            V6 = v6;
            V7 = v7;
            V8 = v8;
            V9 = v9;
            V10 = v10;
            V11 = v11;
        }

        // Methods//////////////////////////////////////////////////////////////////////////////////
        public void GraudeDiabetes()
            {
                if (NivelGlicose < 100)
                {   
                    Console.WriteLine($"Nível de Glicose: {NivelGlicose}");
                    Console.WriteLine("O utente não tem diabetes.");

                }
                else if (NivelGlicose >= 100 && NivelGlicose <= 125)
                {
                    Console.WriteLine($"Nível de Glicose: {NivelGlicose}");
                    Console.WriteLine("O utente tem diabetes tipo 1.");
                }
                else if (NivelGlicose > 125)
                {
                    Console.WriteLine($"Nível de Glicose: {NivelGlicose}");
                    Console.WriteLine("O utente tem diabetes tipo 2.");
                }
             
            }
           
            public void MedidasPA() 
            {
                if (this.PressaoArterialsis < 120 && this.PressaoArterialdia < 80)
                {
                    Console.WriteLine("A pressão arterial do utente é ótima.");
                }
                else if ((this.PressaoArterialsis > 119 && this.PressaoArterialsis < 130) || this.PressaoArterialdia > 79 && this.PressaoArterialdia < 85)
                {
                    Console.WriteLine("A pressão arterial do utente é normal.");
                }
                else if ((this.PressaoArterialsis > 129 && this.PressaoArterialsis < 140) || this.PressaoArterialdia > 84 && this.PressaoArterialdia < 90)
                {
                    Console.WriteLine("Aviso: Utente com HTA NOrmal - Alta (1)");
                }
                else if ((this.PressaoArterialsis > 139 && this.PressaoArterialsis < 160) || this.PressaoArterialdia > 89 && this.PressaoArterialdia < 100)
                {
                    Console.WriteLine("AVISO: Utente com HTA  - Grau I");
                }
                else if ((this.PressaoArterialsis > 160 && this.PressaoArterialsis < 180) || this.PressaoArterialdia > 99 && this.PressaoArterialdia < 110)
                {
                    Console.WriteLine("AVISO: Utente com HTA  - Grau II");
                }
                else if (this.PressaoArterialsis > 180 || this.PressaoArterialdia > 110)
                {
                    Console.WriteLine("AVISO: Utente com HTA  - Grau III");
                }
                else if (this.PressaoArterialsis > 140 && this.PressaoArterialdia < 90)
                {
                    Console.WriteLine("AVISO: Utente Com Hipertensão Sistólica Isolada (2)");
                }
                
            }

            public void CalcImc()
            {
                double imc = Peso / (Altura * Altura);
                Console.WriteLine("O IMC do utente é: " + imc);
                if (imc < 18.5)
                {   
                    Console.WriteLine($"IMC: {imc}");
                    Console.WriteLine("O utente está abaixo do peso.");
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    Console.WriteLine($"IMC: {imc}");
                    Console.WriteLine("O utente está com o peso normal.");
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    Console.WriteLine($"IMC: {imc}");
                    Console.WriteLine("O utente está com excesso de peso.");
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    Console.WriteLine($"IMC: {imc}");
                    Console.WriteLine("O utente está com obesidade grau 1.");
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    Console.WriteLine($"IMC: {imc}");
                    Console.WriteLine("O utente está com obesidade grau 2.");
                }
                else if (imc >= 40)
                {
                    Console.WriteLine($"IMC: {imc}");
                    Console.WriteLine("O utente está com obesidade grau 3.");
                }
            }


        }
    }
