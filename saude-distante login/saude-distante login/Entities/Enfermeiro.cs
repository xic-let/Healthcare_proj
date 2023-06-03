﻿using saude_distante_login.Entities.Enums;
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
        public Enfermeiro()
        {

        }

        public Enfermeiro(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Distrito distrito, string email, int idColaborador, double vencimento, Equipa equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, distrito, email, idColaborador, vencimento, equipa, password)
        {

        }

        //Métodos da classe Enfermeiro

        public bool Autenticar(string funcao, string email, string password)
        {
            // Verificar se a função informada é "médico"
            return base.Email == email && base.Password == password && funcao.ToLower() == "enfermeiro";
        }

        public override void AcessoPermitido()
        {
            base.AcessoPermitido();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Registo de utente");
            Console.WriteLine("2. Aceder relatório estatístico nacional");
            Console.WriteLine("3. Aceder relatório estatístico semanal");
            Console.WriteLine("4. Aceder relatório estatístico diário");
            //Console.WriteLine("5. Aceder relatório consultas");
            Console.WriteLine();
            Console.Write("Opção (1-4): ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    RegistarConsultaEnf();
                    break;
                case "2":
                    RelEstatisticoNacional();
                    break;
                case "3":
                    RelEstatisticoSemanal();
                    break;
                case "4":
                    RelEstatisticoDiario();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }

        protected virtual void RegistoUtente(List<Utente> utentes)  //protected virtual void indica que o método é acessível dentro da classe Colaborador e subclasses, permitindo sobreposição do método nas subclasses
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
            Distrito distrito = Enum.Parse<Distrito>(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Número de Utente do SNS: ");
            int numUtente = int.Parse(Console.ReadLine());

            Console.WriteLine("O utente dá o seu consentimento para o tratamento dos dados de acordo com o RGPD? (Sim/Não):");
            string resp = Console.ReadLine().ToLower();
            bool rGPD = (resp == "sim") ? true : false;

            if (resp == "sim")
            {
                Utente novoUtente = new Utente(nome, genero, dataNascimento, contacto, morada, distrito, email, password, numUtente, rGPD);

                utentes.Add(novoUtente);

                Console.WriteLine("O Registo do Utente foi concluído com sucesso!");
            }
            else
            {
                Console.WriteLine("O Registo do Utente não foi efetuado!");
            }
        }
    }
}
