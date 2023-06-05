using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    
    internal class Enfermeiro : Colaborador
    {
        
        //Construtores da classe Enfermeiro
        public Enfermeiro(){ }

        public Enfermeiro(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, double vencimento, Equipa equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, concelho, email, idColaborador, vencimento, equipa, password)
        {
            

        }

        //Métodos da classe Enfermeiro

        public bool Autenticar(string funcao, string email, string password)
        {
            return base.Email == email && base.Password == password && funcao.ToLower() == "enfermeiro";
        }

        public override void AcessoPermitido()
        {
            base.AcessoPermitido();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Registo de Utente");
            Console.WriteLine("2. Realizar Pré Consulta");
            Console.WriteLine("3. Aceder Relatório Estatístico");
            Console.WriteLine("4. Aceder Relatório de Consultas");
            Console.WriteLine("5. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-5): ");
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
                    RelEstatistico();
                    break;
                case "4":
                    RelConsultas();
                    break;
                case "5":
                    //Logout
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }

        //protected virtual void RegistoUtente(List<Utente> utentes)  //protected virtual void indica que o método é acessível dentro da classe Colaborador e subclasses, permitindo sobreposição do método nas subclasses
        //precisamos de acessar a este metodo na classe de utente que não faz parte da classe colaborador, nem é uma subclasse dela.
        public void RegistoUtente(Utente utente, Utente utentes)
        {
            Console.WriteLine("Registo de Utente:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Género (Masculino/Feminino/Outro: ");
            Genero genero = Enum.Parse<Genero>(Console.ReadLine());

            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

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

            utente.utentes.Add(utentes);

            Console.WriteLine("Utente registado com sucesso!");

        }

        public void RegPreConsulta(Utente utente, Consulta consulta)
        {
        Console.WriteLine("Registe os dados de pré-consulta do utente:");

        Console.Write("Informe a data da consulta (dd/mm/aaaa): ");
        DateTime dataConsulta = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Informe a Equipa Responsável pelo Rastreio: ");
        string equipa = Console.ReadLine();

        Console.Write("Informe o peso: ");
        double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe a altura: ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe a PA Distólica: ");
        int paDistolica = int.Parse(Console.ReadLine());

        Console.Write("Informe a PA Sistólica: ");
        int paSistolica = int.Parse(Console.ReadLine());

        Console.Write("Informe o nivel de Glicose: ");
        double glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            utente.consultas.Add(consulta);

            //inserir dados na tabela da consulta
        Console.WriteLine("Dados de pré-consulta registrados com sucesso!");
        }
    }
}
