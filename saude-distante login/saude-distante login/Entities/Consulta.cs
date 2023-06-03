using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using saude_distante_login.Entities.Enums;

namespace saude_distante_login.Entities
{
    internal class Consulta // consulta não pode ser herdada de utente par permitir o registo de consulta
    {
        public DateTime Data { get; set; }
        public Equipa equipa { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public bool Fumador { get; set; }
        public string HistoricoDoencas { get; set; }
        public double NivelGlicose { get; set; }
        public double PressaoArterialsis { get; set; }
        public double PressaoArterialdia { get; set; }
        public string observacoes { get; set; }

        public string receitas { get; set; }

        public Utente utente { get; set; }

        public DadosSaude DadosSaude { get; set; }
        
        //Construtores

        public Consulta(DateTime data, Equipa equipa, double peso, double altura, bool fumador, string historicoDoencas, double nivelGlicose, double pressaoArterialsis, double pressaoArterialdia, string observacoes, string receitas, string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Distrito distrito, string email, int id, bool yes_rgpd)
        : base (nome, genero, dataNascimento, contacto, morada, distrito, email, id, yes_rgpd)
        {
            this.Data = data;
            this.equipa = equipa;
            this.Peso = peso;
            this.Altura = altura;
            this.Fumador = fumador;
            this.HistoricoDoencas = historicoDoencas;
            this.NivelGlicose = nivelGlicose;
            this.PressaoArterialsis = pressaoArterialsis;
            this.PressaoArterialdia = pressaoArterialdia;
            this.observacoes = observacoes;
            this.receitas = receitas;
        }


        // Métodos 

        public void AdicionarDadosSaude()
        {
            Consulta dadosSaude = new consulta();

            Console.WriteLine("Registe os dados de saúde do utente:");
            Console.Write("É fumador? (sim/não): ");
            string fumadorInput = Console.ReadLine();
            consulta.Fumador = fumadorInput.ToLower() == "sim"; // true se sim, false se não

            Console.Write("Informe o histórico de doenças: ");
            consulta.HistoricoDoencas = Console.ReadLine();

            Console.Write("Informe o nível de glicose: ");
            double nivelGlicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            consulta.NivelGlicose = nivelGlicose;

            Console.Write("Informe a pressão arterial sistólica: ");
            double pressaoSistolica = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            consulta.PressaoArterialsis = pressaoSistolica;

            Console.Write("Informe a pressão arterial diastólica: ");
            double pressaoDiastolica = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            consulta.pressaoArterialdia = pressaoDiastolica;

            Console.Write("Informe o peso: ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            consulta.Peso = peso;

            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            consulta.Altura = altura;

            consulta.Add(dadosSaude);//adiciona os dados de saúde à lista de dados de saúde do utente

            Console.WriteLine("Dados de saúde registados com sucesso!");
        }

        public void RelConsultaInd()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Relatório da consulta:");
            Console.WriteLine();
            Console.WriteLine("Data da Consulta: " + Consulta.DataConsulta);
            Console.WriteLine("Médio responsável: " + Consulta.equipa.Medico);
            Console.WriteLine("Enfermeiro responsável: " + Consulta.equipa.Enfermeiro);
            Console.WriteLine("Nome do utente: " + utente.Nome);
            Console.WriteLine("Género: " + utente.Genero);
            Console.WriteLine("Data de nascimento: " + utente.DataNascimento);
            Console.WriteLine("Contacto: " + utente.Contacto);
            Console.WriteLine("Morada: " + utente.Morada);
            Console.WriteLine("Distrito: " + utente.Distrito);
            Console.WriteLine("Email: " + utente.Email);
            Console.WriteLine("Fumador: " + utente.DadosSaude.Fumador);
            Console.WriteLine("Histórico de doenças: " + utente.DadosSaude.HistoricoDoencas);
            Console.WriteLine("Observações: " + utente.DadosSaude.Observacoes);
            Console.WriteLine("Peso: " + utente.DadosSaude.Peso);
            Console.WriteLine("Altura: " + utente.DadosSaude.Altura);
            Console.WriteLine("Pressão arterialSistólica: " + utente.DadosSaude.PressaoArterialsis);
            Console.WriteLine("Pressão arterial Diastólica: " + utente.DadosSaude.PressaoArterialdias);
            COnsole.WriteLine("Nivel de Glicose no Sangue: " + utente.DadosSaude.Glicose);
            Console.WriteLine("Medicação: " + utente.DadosSaude.Receitas);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Análise de Risco do Utente:");
            Console.WriteLine("Grau de diabetes: " + GraudeDiabetes());
            Console.WriteLine("Medidas de pressão arterial: " + MedidasPA());
            Console.WriteLine("IMC: " + IMC());
            Console.WriteLine("--------------------------------------------------");
        }

        public void GraudeDiabetes()  //verificar niveis no enunciado
        {
            if (Consulta.NivelGlicose < 100)
            {
                Console.WriteLine("O utente não tem diabetes.");
            }
            else if (Consulta.NivelGlicose >= 100 && Consulta.NivelGlicose <= 125)
            {
                Console.WriteLine("O utente tem diabetes tipo 1.");
            }
            else if (Consulta.NivelGlicose > 125)
            {
                Console.WriteLine("O utente tem diabetes tipo 2.");
            }
        }

        public void MedidasPA() //verificar niveis no enunciado
        {
            if (Consulta.PressaoArterialsis < 120 && Consulta.pressaoArterialdia < 80)
            {
                Console.WriteLine("A pressão arterial do utente é ótima.");
            }
            else if ((Consulta.PressaoArterialsis > 119 && Consulta.PressaoArterialsis < 130) || Consulta.pressaoArterialdia > 79 && Consulta.pressaoArterialdia < 85)
            {
                Console.WriteLine("A pressão arterial do utente é normal.");
            }
            else if ((Consulta.PressaoArterialsis > 129 && Consulta.PressaoArterialsis < 140) || Consulta.pressaoArterialdia > 84 && Consulta.pressaoArterialdia < 90)
            {
                Console.WriteLine("Aviso: Utente com HTA NOrmal - Alta (1)");
            }
            else if ((Consulta.PressaoArterialsis > 139 && Consulta.PressaoArterialsis < 160) || Consulta.pressaoArterialdia > 89 && Consulta.pressaoArterialdia < 100)
            {
                Console.WriteLine("AVISO: Utente com HTA  - Grau I");
            }
            else if ((Consulta.PressaoArterialsis > 160 && Consulta.PressaoArterialsis < 180) || Consulta.pressaoArterialdia > 99 && Consulta.pressaoArterialdia < 110)
            {
                Console.WriteLine("AVISO: Utente com HTA  - Grau II");
            }
            else if (Consulta.PressaoArterialsis > 180 || Consulta.pressaoArterialdia > 110)
            {
                Console.WriteLine("AVISO: Utente com HTA  - Grau III");
            }
            else if (Consulta.PressaoArterialsis > 140 &&  Consulta.pressaoArterialdia < 90)
            {
                Console.WriteLine("AVISO: Utente Com Hipertensão Sistólica Isolada (2)");
            }
        }

        public void IMC()
        {
            double imc = Consulta.Peso / (Consulta.Altura * Consulta.Altura);
            Console.WriteLine("O IMC do utente é: " + imc);
            if(imc < 18.5)
            {
                Console.WriteLine("O utente está abaixo do peso.");
            }
            else if(imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("O utente está com o peso normal.");
            }
            else if(imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("O utente está com excesso de peso.");
            }
            else if(imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("O utente está com obesidade grau 1.");
            }
            else if(imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("O utente está com obesidade grau 2.");
            }
            else if(imc >= 40)
            {
                Console.WriteLine("O utente está com obesidade grau 3.");
            }
        }


    }
}
