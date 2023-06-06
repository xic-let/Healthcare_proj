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
        //public Administrativo() {}

        public Administrativo(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, Equipa equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, concelho, email, idColaborador, funcao, vencimento, equipa, password)
        {

        }


        //Métodos da classe Administrativo

        public bool Autenticar(string funcao, string email, string password)
        {
            return base.Email == email && base.Password == password && funcao.ToLower() == "administrativo";
        }

        public override void AcessoPermitido()
        {
            base.AcessoPermitido();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Adicionar Equipa");
            Console.WriteLine("2. Aceder Relatório de Colaboradores");
            Console.WriteLine("3. Aceder Relatório Estatístico");
            Console.WriteLine("4. Agendar Rota"); //o email é enviado automaticamente ao fazer o registo da rota
            Console.WriteLine("5. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-5): ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    RegistarEquipa(); //resolver equipas
                    break;
                case "2":
                    RelatorioColaboradores();
                    break;
                case "3":
                    RelEstatistico();
                    break;
                case "4":
                    AdicionarRota(); //resolver equipas
                    break;
                case "5":
                    //Logout
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }


        public void RegistarEquipa(Administrativo administrativo)
        {
            Equipa equipa = new Equipa(); //listas das equipas devem ser resolvidas para tirar este erro
            equipa.Administrativo = administrativo;

            Console.Write("Insira o ID da equipa: ");
            equipa.IdEquipa = int.Parse(Console.ReadLine());
            Console.Write("Insira o Concelho da equipa: ");
            equipa.concelho = Enum.Parse<Concelho>(Console.ReadLine());

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
            Console.Write("Concelho: ");
            Concelho enfConcelho = Enum.Parse<Concelho>(Console.ReadLine());
            Console.Write("Email: ");
            string enfEmail = Console.ReadLine();
            Console.Write("ID de colaborador: ");
            int enfIdColaborador = int.Parse(Console.ReadLine());
            Console.Write("Função: ");
            string enfFuncao = Console.ReadLine();
            Console.Write("Vencimento: ");
            double enfVencimento = double.Parse(Console.ReadLine());
            Console.Write("Password: ");
            string enfPassword = Console.ReadLine();
            Enfermeiro enfermeiro = new Enfermeiro(enfNome, enfGenero, enfDataNascimento, enfContacto, enfMorada, enfConcelho, enfEmail, enfIdColaborador, enfFuncao, enfVencimento, equipa, enfPassword);

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
            Console.Write("Concelho: ");
            Concelho medConcelho = Enum.Parse<Concelho>(Console.ReadLine());
            Console.Write("Email: ");
            string medEmail = Console.ReadLine();
            Console.Write("ID de colaborador: ");
            int medIdColaborador = int.Parse(Console.ReadLine());
            Console.Write("Função: ");
            string medFuncao = Console.ReadLine();
            Console.Write("Vencimento: ");
            double medVencimento = double.Parse(Console.ReadLine());
            Console.Write("Password: ");
            string medPassword = Console.ReadLine();
            Medico medico = new Medico(medNome, medGenero, medDataNascimento, medContacto, medMorada, medConcelho, medEmail, medIdColaborador, medFuncao, medVencimento, equipa, medPassword);

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
            Console.Write("Concelho: ");
            Concelho motConcelho = Enum.Parse<Concelho>(Console.ReadLine());
            Console.Write("Email: ");
            string motEmail = Console.ReadLine();
            Console.Write("ID de colaborador: ");
            int motIdColaborador = int.Parse(Console.ReadLine());
            Console.Write("Função: ");
            string motFuncao = Console.ReadLine();
            Console.Write("Vencimento: ");
            double motVencimento = double.Parse(Console.ReadLine());
            Console.Write("Password: ");
            string motPassword = Console.ReadLine();
            Motorista motorista = new Motorista(motNome, motGenero, motDataNascimento, motContacto, motMorada, motConcelho, motEmail, motIdColaborador, motFuncao, motVencimento, equipa, motPassword);

            equipa.Enfermeiro = enfermeiro;
            equipa.Medico = medico;
            equipa.Motorista = motorista;

            Equipas.Add(equipa);

            Console.WriteLine();
            Console.WriteLine("Equipa " + equipa.IdEquipa + " (" + equipa.Concelho + ") criada com sucesso.");
        }

        public void RelatorioColaboradores()
        {
            Console.WriteLine("RELATÓRIO DE COLABORADORES:");
            foreach (Equipa equipa in Equipas)
            {
                Console.WriteLine("Equipa " + equipa.IdEquipa + " (" + equipa.Concelho + "):\n"
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
                    Console.WriteLine("Equipa " + equipa.IdEquipa + " (" + equipa.Concelho + "):\n"
                     + "Administrativo: " + equipa.Administrativo.Nome + " (vencimento: " + equipa.Administrativo.Vencimento + "€)\n"
                     + "Enfermeiro: " + equipa.Enfermeiro.Nome + " (vencimento: " + equipa.Enfermeiro.Vencimento + "€)\n"
                     + "Médico: " + equipa.Medico.Nome + " (vencimento: " + equipa.Medico.Vencimento + "€)\n"
                     + "Motorista: " + equipa.Motorista.Nome + " (vencimento: " + equipa.Motorista.Vencimento + "€)");
                    Console.WriteLine();
                }
            }

            Console.WriteLine(" Qual a função do COLABORADOR? ");
            Console.WriteLine(" 1 - Administrativo ");
            Console.WriteLine(" 2 - Enfermeiro ");
            Console.WriteLine(" 3 - Médico ");
            Console.WriteLine(" 4 - Motorista ");
            int res = int.Parse(Console.ReadLine());

            if (res == 1)
            {
                string função = "Administrativo";
            }
        }

        public void AdicionarRota(Rotas novaRota, List<Rotas> rotas) //resolver equipas para nao dar erro
        {
            rotas.Add(novaRota);

            rotas.Add(1, Enums.Concelho.Braga, "Sao Vitor", equipa1);
            rotas.Add(2, Enums.Concelho.Braga, "Gualtar", equipa1);
            rotas.Add(3, Enums.Concelho.Amares, "Amares e Figueiredo", equipa2);
            rotas.Add(4, Enums.Concelho.Amares, "Dornelas", equipa2);
            rotas.Add(5, Enums.Concelho.Guimarães, "Azurém", equipa3);
            rotas.Add(6, Enums.Concelho.Guimarães, "Creixomil", equipa3);
        }
    }

}

}

