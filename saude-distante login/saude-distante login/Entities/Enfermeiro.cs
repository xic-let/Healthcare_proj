using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    
    public class Enfermeiro : Colaborador
    {

        //Construtores da classe Enfermeiro

        public Enfermeiro()
            :base()
        {}

        public Enfermeiro(string nome, Genero genero, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, int equipa, string password)
            : base(nome, genero, contacto, morada, concelho, email, idColaborador, funcao, vencimento, password, equipa)
        {}

        //Métodos da classe Enfermeiro


        public void MostrarMenuEnfermeiro()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Bem-vindo/a " + this.Nome);
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Registo de Utente");
            Console.WriteLine("2. Realizar Pré Consulta");
            Console.WriteLine("3. Aceder Relatório Estatístico");
            Console.WriteLine("4. Aceder Relatório de Consultas");
            Console.WriteLine("5. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-5): ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    RegistoUtente();
                    break;
                case "2":
                    RegPreConsulta(); 
                    break;
                case "3":
                    Utente.RelEstatistico();
                    break;
                case "4":
                    RelConsultas();
                    break;
                case "5":
                    Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }

        
        public void RegistoUtente()
        {
            Console.WriteLine("Registo de Utente:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Género (Masculino/Feminino/Outro): ");
            Genero genero = Enum.Parse<Genero>(Console.ReadLine());

            Console.Write("Contacto: ");
            string contacto = Console.ReadLine();

            Console.Write("Morada: ");
            string morada = Console.ReadLine();

            Console.Write("Concelho: ");
            Concelho concelho = Enum.Parse<Concelho>(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Número de Utente do SNS: ");
            int numUtente = int.Parse(Console.ReadLine());

            Console.WriteLine("O utente dá o seu consentimento para o tratamento dos dados de acordo com o RGPD? (Sim/Não):");
            string resp = Console.ReadLine().ToLower();

            bool yes_rgpd = (resp == "sim" || resp == "Sim" || resp == "SIM");

            Utente utente = new Utente(nome, genero, contacto, morada, concelho, email, numUtente, yes_rgpd);

            Listas.Utentes.Add(utente);

            Console.WriteLine("Utente registado com sucesso!");

            Console.WriteLine();

            Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
            string resposta = Console.ReadLine();
            if (resposta == "nao")
            {
                Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                Environment.Exit(0);
            }
            else
            {
                MostrarMenuEnfermeiro();
            }

        }

        public void ImprimefichaUtente()
        {
            Console.WriteLine("Insira o Nr de Utente: ");
            int id = int.Parse(Console.ReadLine());

            // Procurar o utente na lista de utentes
            Utente utenteEncontrado = Listas.Utentes.Find(u => u.Idsns == id);

            if (utenteEncontrado != null)
            {
                Console.WriteLine("Ficha do Utente:");
                Console.WriteLine(utenteEncontrado);
            }
            else
            {
                Console.WriteLine("O utente não possui consultas registadas.");
            }

        }

        public static void RegPreConsulta() 
        {
            Console.WriteLine("Insira o Nr de Utente: ");
            int id = int.Parse(Console.ReadLine());

            // Procurar o utente na lista de utentes
            Utente utenteEncontrado = Listas.Utentes.Find(u => u.Idsns == id);//não encontra lista de utentes

            if (utenteEncontrado != null)
            {
                Console.WriteLine("Registe os dados de pré-consulta do utente:");

                Console.Write("Informe a data da consulta (dd/mm/aaaa): ");
                DateTime dataConsulta = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Informe a Equipa Responsável pelo Rastreio: ");
                int equipa = int.Parse(Console.ReadLine());

                Console.Write("Informe o peso: ");
                double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Informe a altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Informe a PA Distólica: ");
                double pressaoArterialdia = double.Parse(Console.ReadLine());

                Console.Write("Informe a PA Sistólica: ");
                double pressaoArterialsis = double.Parse(Console.ReadLine());

                Console.Write("Informe o nivel de Glicose: ");
                double glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Consulta consulta = new Consulta(dataConsulta, equipa, peso, altura, pressaoArterialdia, pressaoArterialsis, glicose);
                utenteEncontrado.Consulta = consulta;
                //Listas.Consultas.Add(consulta);

                //inserir dados na tabela da consulta
                Console.WriteLine("Dados de pré-consulta registados com sucesso!");

                Console.WriteLine();

                Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
                string resposta = Console.ReadLine();
                if (resposta == "nao")
                {
                    Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                    Environment.Exit(0);
                }
                else
                {
                    Enfermeiro enfermeiro = new Enfermeiro();
                    enfermeiro.MostrarMenuEnfermeiro();
                }
            }
            else
            {
                Console.WriteLine("Utente não encontrado. É necessário registar o utente antes de prosseguir.");
                Console.WriteLine("Deseja registar o utente? (sim/não): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "sim")
                {
                    // Chamar o método para registar o utente
                    Enfermeiro enfermeiro = new Enfermeiro();
                    enfermeiro.RegistoUtente();
                }
                else
                {
                    Console.WriteLine("Operação cancelada.");
                    Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
                    string resposta = Console.ReadLine();
                    if (resposta == "nao")
                    {
                        Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Enfermeiro enfermeiro = new Enfermeiro();
                        enfermeiro.MostrarMenuEnfermeiro();
                    }
                }
            }
        }
    }
}
