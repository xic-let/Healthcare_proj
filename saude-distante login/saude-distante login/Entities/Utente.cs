using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace saude_distante_login.Entities
{
    internal class Utente : Pessoa
    {
       
       public int Idsns { get; set; }
       public bool Yes_Rgpd { get; set; } // true = aceita, false = não aceita

       public List<Utente> utentes { get; set; }
       public List<Consulta> Consultas { get; set; }


        public Utente(string nome, Genero genero, DateTime dataNascimento,string contacto , string morada, Concelho concelho, string email, int id, bool yes_rgpd)
        :base(nome, genero, dataNascimento, contacto, morada, concelho, email)
        {
            Idsns = id;
            Yes_Rgpd = yes_rgpd;
            utentes = new List<Utente>();
            Consultas = new List<Consulta>();

        }

        public void RelConsultaInd()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Relatório da consulta:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("ID do Utente:");
            int id = int.Parse(Console.ReadLine());

            // Procurar o utente na lista de utentes
            Utente utente = utentes.Find(u => u.Idsns == id);

            if (utente != null)
            {
                Console.WriteLine("Dados do Utente:");
                Console.WriteLine($"Nome: {utente.Nome}");
                Console.WriteLine($"Género: {utente.Genero}");
                Console.WriteLine($"Data de Nascimento: {utente.DataNascimento.ToShortDateString()}");
                Console.WriteLine($"Contacto: {utente.Contacto}");
                Console.WriteLine($"Morada: {utente.Morada}");
                Console.WriteLine($"Distrito: {utente.Concelho}");
                Console.WriteLine($"Email: {utente.Email}");
                Console.WriteLine($"ID: {utente.Idsns}");
                Console.WriteLine($"RGPD: {utente.Yes_Rgpd}");

                // Verificar se o utente possui consultas
                if (utente.Consultas.Count > 0)
                {
                    Console.WriteLine("Dados da Consulta:");

                    // Iterar sobre as consultas do utente
                    foreach (Consulta consulta in utente.consultas)
                    {
                        Console.WriteLine($"Data da Consulta: {consulta.Data.ToShortDateString()}");
                        Console.WriteLine($"Equipa: {consulta.Equipa}");
                        Console.WriteLine($"Peso: {consulta.Peso}");
                        Console.WriteLine($"Altura: {consulta.Altura}");
                        Console.WriteLine($"Fumador: {consulta.Fumador}");
                        Console.WriteLine($"Histórico de Doenças: {consulta.HistoricoDoencas}");
                        Console.WriteLine($"Nível de Glicose: {consulta.NivelGlicose}");
                        Console.WriteLine($"Pressão Arterial (Sistólica): {consulta.PressaoArterialsis}");
                        Console.WriteLine($"Pressão Arterial (Diastólica): {consulta.PressaoArterialdia}");
                        Console.WriteLine($"Observações: {consulta.Observacoes}");
                        Console.WriteLine($"Receitas: {consulta.Receitas}");
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Análise de Risco do Utente:");
                        // Calcular e exibir o IMC do utente
                        consulta.CalcImc();
                        // Verificar se o utente tem diabetes
                        consulta.GraudeDiabetes();
                        // Verificar a classificação da pressão arterial do utente
                        consulta.MedidasPA();
                        Console.WriteLine("--------------------------------------------------");

                    }
                }
                else
                {
                    Console.WriteLine("O utente não possui consultas registadas.");
                }
            }
            else
            {
                Console.WriteLine("Utente não encontrado.");
            }
        }


    }

}


