using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using saude_distante_login.Services;

namespace saude_distante_login.Entities
{
    internal class Administrativo : Colaborador, IAutenticacao
    {
        //Construtores da classe Administrativo
        public Administrativo()
        {

        }

        public Administrativo(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Distrito distrito, string email, int idColaborador, double vencimento, Equipa equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, distrito, email, idColaborador, vencimento, equipa, password)
        {

        }


        //Métodos da classe Administrativo

        public bool Autenticar(string funcao, string email, string password)
        {
            // Verificar se a função informada é "administrativo"
            return base.Email == email && base.Password == password && funcao.ToLower() == "administrativo";
        }

        public override void AcessoPermitido()
        {
            base.AcessoPermitido();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Adicionar equipa");
            Console.WriteLine("2. Aceder relatório de colaboradores");
            Console.WriteLine("3. Aceder relatório estatístico nacional");
            Console.WriteLine("4. Aceder relatório estatístico semanal");
            Console.WriteLine("5. Aceder relatório estatístico diário");
            Console.WriteLine("6. Agendar Rota"); //o email é enviado automaticamente ao fazer o registo da rota?
            Console.WriteLine();
            Console.Write("Opção (1-6): ");
            string opcao = Console.ReadLine(); 

            switch (opcao)
            {
                case "1":
                    RegistarEquipa();
                    break;
                case "2":
                    RelatorioColaboradores();
                    break;
                case "3":
                    RelEstatisticoNacional();
                    break;
                case "4":
                    RelEstatisticoSemanal();
                    break;
                case "5":
                    RelEstatisticoDiario();
                    break;
                case "6":
                    PlanoRota();
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }


        public void RegistarEquipa(Administrativo administrativo)
        {
            Equipa equipa = new Equipa();
            equipa.Administrativo = administrativo;

            Console.Write("Insira o ID da equipa: ");
            equipa.IdEquipa = int.Parse(Console.ReadLine());
            Console.Write("Insira o distrito da equipa: ");
            equipa.Distrito = Enum.Parse<Distrito>(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do enfermeiro da equipa:");
            Console.Write("Nome: ");
            string enfNome = Console.ReadLine();
            Console.Write("Género: ");
            Genero enfGenero = Enum.Parse<Genero>(Console.ReadLine());
            Console.Write("Data de nascimento: ");
            DateTime enfDataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Contacto: ");
            string enfContacto = Console.ReadLine();
            Console.Write("Morada: ");
            string enfMorada = Console.ReadLine();
            Console.Write("Distrito: ");
            Distrito enfDistrito = Enum.Parse<Distrito>(Console.ReadLine());
            Console.Write("Email: ");
            string enfEmail = Console.ReadLine();
            Console.Write("ID de colaborador: ");
            int enfIdColaborador = int.Parse(Console.ReadLine());
            Console.Write("Vencimento: ");
            double enfVencimento = double.Parse(Console.ReadLine());
            Console.Write("Password: ");
            string enfPassword = Console.ReadLine();
            Enfermeiro enfermeiro = new Enfermeiro(enfNome, enfGenero, enfDataNascimento, enfContacto, enfMorada, enfDistrito, enfEmail, enfIdColaborador, enfVencimento, equipa, enfPassword);

            Console.WriteLine();

            Console.WriteLine("Dados do médico da equipa:");
            Console.Write("Nome: ");
            string medNome = Console.ReadLine();
            Console.Write("Género: ");
            Genero medGenero = Enum.Parse<Genero>(Console.ReadLine());
            Console.Write("Data de nascimento: ");
            DateTime medDataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Contacto: ");
            string medContacto = Console.ReadLine();
            Console.Write("Morada: ");
            string medMorada = Console.ReadLine();
            Console.Write("Distrito: ");
            Distrito medDistrito = Enum.Parse<Distrito>(Console.ReadLine());
            Console.Write("Email: ");
            string medEmail = Console.ReadLine();
            Console.Write("ID de colaborador: ");
            int medIdColaborador = int.Parse(Console.ReadLine());
            Console.Write("Vencimento: ");
            double medVencimento = double.Parse(Console.ReadLine());
            Console.Write("Password: ");
            string medPassword = Console.ReadLine();
            Medico medico = new Medico(medNome, medGenero, medDataNascimento, medContacto, medMorada, medDistrito, medEmail, medIdColaborador, medVencimento, equipa, medPassword);

            Console.WriteLine();

            Console.WriteLine("Dados do motorista da equipa:");
            Console.Write("Nome: ");
            string motNome = Console.ReadLine();
            Console.Write("Género: ");
            Genero motGenero = Enum.Parse<Genero>(Console.ReadLine());
            Console.Write("Data de nascimento: ");
            DateTime motDataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Contacto: ");
            string motContacto = Console.ReadLine();
            Console.Write("Morada: ");
            string motMorada = Console.ReadLine();
            Console.Write("Distrito: ");
            Distrito motDistrito = Enum.Parse<Distrito>(Console.ReadLine());
            Console.Write("Email: ");
            string motEmail = Console.ReadLine();
            Console.Write("ID de colaborador: ");
            int motIdColaborador = int.Parse(Console.ReadLine());
            Console.Write("Vencimento: ");
            double motVencimento = double.Parse(Console.ReadLine());
            Console.Write("Password: ");
            string motPassword = Console.ReadLine();
            Motorista motorista = new Motorista(motNome, motGenero, motDataNascimento, motContacto, motMorada, motDistrito, motEmail, motIdColaborador, motVencimento, equipa, motPassword);

            equipa.Enfermeiro = enfermeiro;
            equipa.Medico = medico;
            equipa.Motorista = motorista;

            Equipas.Add(equipa);

            Console.WriteLine();
            Console.WriteLine("Equipa " + equipa.IdEquipa + " (" + equipa.Distrito + ") criada com sucesso.");
        }

        public void RelatorioColaboradores()
        {
            Console.WriteLine("RELATÓRIO DE COLABORADORES:");
            foreach (Equipa equipa in Equipas)
            {
                Console.WriteLine("Equipa " + equipa.IdEquipa + " (" + equipa.Distrito + "):\n"
                + "Administrativo: " + equipa.Administrativo.Nome + " (vencimento: " + equipa.Administrativo.Vencimento + "€)\n"
                + "Enfermeiro: " + equipa.Enfermeiro.Nome + " (vencimento: " + equipa.Enfermeiro.Vencimento + "€)\n"
                + "Médico: " + equipa.Medico.Nome + " (vencimento: " + equipa.Medico.Vencimento + "€)\n"
                + "Motorista: " + equipa.Motorista.Nome + " (vencimento: " + equipa.Motorista.Vencimento + "€)");
                Console.WriteLine();
            }
        }

        public void RelatorioEquipa(int idEquipa)
        {
            foreach (Equipa equipa in Equipas)
            {
                if (idEquipa == equipa.IdEquipa)
                {
                    Console.WriteLine("Equipa " + equipa.IdEquipa + " (" + equipa.Distrito + "):\n"
                     + "Administrativo: " + equipa.Administrativo.Nome + " (vencimento: " + equipa.Administrativo.Vencimento + "€)\n"
                     + "Enfermeiro: " + equipa.Enfermeiro.Nome + " (vencimento: " + equipa.Enfermeiro.Vencimento + "€)\n"
                     + "Médico: " + equipa.Medico.Nome + " (vencimento: " + equipa.Medico.Vencimento + "€)\n"
                     + "Motorista: " + equipa.Motorista.Nome + " (vencimento: " + equipa.Motorista.Vencimento + "€)");
                    Console.WriteLine();
                }
            }
        }
    }
}
