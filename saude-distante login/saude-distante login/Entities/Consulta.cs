using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using saude_distante_login.Entities.Enums;

namespace saude_distante_login.Entities
{
    internal class Consulta : Utente 
    {
        public DateTime Data { get; set; }
        public string Hora { get; set; }
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
        public List<Consulta> dadosSaude { get; set; }

       

        public Consulta()
        { } // Construtor vazio

        public Consulta(DateTime data, string hora, Equipa equipa, double peso, double altura, bool fumador, string historicoDoencas, double nivelGlicose, double pressaoArterialsis, double pressaoArterialdia, string observacoes, string receitas, string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Distrito distrito, string email, int id, bool yes_rgpd)
        : base (nome, genero, dataNascimento, contacto, morada, distrito, email, id, yes_rgpd)
        {
            this.Data = data;
            this.Hora = hora;
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
            Consulta dadosSaude = new Consulta();

            Console.WriteLine("Registe os dados de saúde do utente:");
            Console.Write("É fumador? (sim/não): ");
            string fumadorInput = Console.ReadLine();
            Consulta.Fumador = fumadorInput.ToLower() == "sim"; // true se sim, false se não

            Console.Write("Informe o histórico de doenças: ");
            Consulta.HistoricoDoencas = Console.ReadLine();

            Console.Write("Informe o nível de glicose: ");
            double nivelGlicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Consulta.NivelGlicose = nivelGlicose;

            Console.Write("Informe a pressão arterial sistólica: ");
            double pressaoSistolica = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dadosSaude.PressaoArterialsis = pressaoSistolica;

            Console.Write("Informe a pressão arterial diastólica: ");
            double pressaoDiastolica = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dadosSaude.pressaoArterialdia = pressaoDiastolica;

            Console.Write("Informe o peso: ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dadosSaude.Peso = peso;

            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dadosSaude.Altura = altura;

            Consulta.Add(dadosSaude);//adiciona os dados de saúde à lista de dados de saúde do utente

            Console.WriteLine("Dados de saúde registados com sucesso!");
        }

        public void MostrarDadosSaude()
        {
            Console.WriteLine("Dados de saúde do utente:");
            Console.WriteLine("Fumador: " + Consulta.Fumador);
            Console.WriteLine("Histórico de doenças: " + Consulta.HistoricoDoencas);
            Console.WriteLine("Nível de glicose: " + Consulta.NivelGlicose);
            Console.WriteLine("Pressão arterial sistólica: " + Consulta.PressaoArterialsis);
            Console.WriteLine("Pressão arterial diastólica: " + Consulta.PressaoArterialdia);
            Console.WriteLine("Peso: " + Consulta.Peso);
            Console.WriteLine("Altura: " + Consulta.Altura);
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
                Console.WriteLine("A pressão arterial do utente é normal.");
            }
            else if (Consulta.PressaoArterialsis >= 120 && Consulta.PressaoArterialsis <= 129 && Consulta.pressaoArterialdia < 80)
            {
                Console.WriteLine("A pressão arterial do utente é elevada.");
            }
            else if (Consulta.PressaoArterialsis >= 130 && Consulta.PressaoArterialsis <= 139 || Consulta.pressaoArterialdia >= 80 && Consulta.pressaoArterialdia <= 89)
            {
                Console.WriteLine("A pressão arterial do utente é elevada.");
            }
            else if (Consulta.PressaoArterialsis >= 140 || Consulta.pressaoArterialdia >= 90)
            {
                Console.WriteLine("A pressão arterial do utente é elevada.");
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

        public void RelDiarioConsulta()
        {
            //numero de consultas realizadas no dia
            //numero de consultas realizadas por concelho
            //total de consultas realizadas
            //numero de utentes com nivel de glicose acima do normal
            //numero de utentes com pressao arterial acima do normal
            //numero de utentes com IMC acima do normal
            //numero de utentes com diabetes
            //numero de utentes com obesidade
            //numero de utentes com hipertensao
            //numero de utentes com pressao arterial normal
            //numero de utentes com IMC normal
            //numero de utentes com nivel de glicose normal
            //numero de utentes com peso normal
            //numero de utentes com peso abaixo do normal
            //numero de utentes com peso acima do normal
            //numero de utentes com IMC baixo
            
        }

    }
}
