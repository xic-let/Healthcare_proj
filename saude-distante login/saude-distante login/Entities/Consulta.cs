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
        DateTime Data { get; set; }
        Equipa Equipa { get; set; }
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
        Utente Utente { get; set; }
        Consulta consulta { get; set; }

        //Construtores////////////////////////////////////////////////////////////////////////////////

        public Consulta() { }

        public Consulta (DateTime data, Equipa equipa, double peso, double altura, bool fumador, string historicoDoencas, double nivelGlicose, double pressaoArterialsis, double pressaoArterialdia, string observacoes, string receitas, int numutente, Utente utente, Consulta consultas)

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

            List <Consulta> Consulta = new List<Consulta>();

            Consulta.Add(new Consulta(new DateTime(20 - 05 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 1));
            Consulta.Add(new Consulta(new DateTime(20 - 05 - 2023), 2, 65, 1.62, true, "N/A", 85, 122, 90, "N/A", "N/A", 2));
            Consulta.Add(new Consulta(new DateTime(27 - 05 - 2023), 3, 95, 1.85, false, "N/A", 81, 119, 82, "N/A", "Artovastatina", 3));
            Consulta.Add(new Consulta(new DateTime(27 - 05 - 2023), 2, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 4));
            Consulta.Add(new Consulta(new DateTime(01 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 5));
            Consulta.Add(new Consulta(new DateTime(02 - 06 - 2023), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 6));
            Consulta.Add(new Consulta(new DateTime(05 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 7));
            Consulta.Add(new Consulta(new DateTime(05 - 06 - 2023), 2, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Artovastatina", 8));
            Consulta.Add(new Consulta(new DateTime(05 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 9));
            Consulta.Add(new Consulta(new DateTime(06 - 06 - 2023), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 10));
            Consulta.Add(new Consulta(new DateTime(07 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 11));
            Consulta.Add(new Consulta(new DateTime(08 - 06 - 2023), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 12));
            Consulta.Add(new Consulta(new DateTime(08 - 06 - 2023), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 13));

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
