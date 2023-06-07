using Microsoft.VisualBasic;
using saude_distante_login.Entities.Enums;
using saude_distante_login.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace saude_distante_login.Entities
{
    internal class Medico : Colaborador, IAutenticacao
    {
        //Construtores da classe Medico
        

        public Medico(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, int equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, concelho, email, idColaborador, funcao, vencimento, equipa, password)
        {

        }


        //Métodos da classe Medico


        public bool Autenticar(string funcao, string email, string password)
        {
            return base.Email == email && base.Password == password && funcao.ToLower() == "médico";
        }

        public override void AcessoPermitido()
        {
            base.AcessoPermitido();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Realizar consulta");
            Console.WriteLine("2. Aceder Relatório Estatístico");
            Console.WriteLine("3. Aceder Relatório de Consultas");
            Console.WriteLine("4. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-4: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    RegistarConsultaMed();
                    break;
                case "2":
                    RelEstatistico();
                    break;
                case "3":
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
        
        public void RegistarConsultaMed(Utente utente, Consulta consulta )
        {
            Console.WriteLine("Registe os dados da consulta:");
            if (utente.consultas == null)
            {
                Console.WriteLine("É necessário registrar os dados de pré-consulta antes de prosseguir.");
                Console.WriteLine("Deseja registrar os dados de pré-consulta? (sim/não): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "sim")
                {
                    Enfermeiro enfermeiro = new Enfermeiro();
                    enfermeiro.RegPreConsulta(utente, consulta);
                    Console.WriteLine("Continuar com o registo da consulta? (sim/não): ");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "sim")
                    {
                        RegistarConsultaMed(utente, consulta);  // Chama o método novamente para continuar o registo da consulta
                    }
                    else
                    {
                        Console.WriteLine("Operação cancelada.");
                        base.AcessoPermitido();
                    }
                }
                else
                {
                    Console.WriteLine("Operação cancelada.");
                    base.AcessoPermitido();
                }
            }

            Console.WriteLine("Registe os dados da consulta:");

            Console.Write("É fumador? (sim/não): ");
            bool fumador = bool.Parse(Console.ReadLine());

            Console.Write("Informe o histórico de doenças: ");
            string historicoDoencas = Console.ReadLine();

            Console.Write("Existem Observações a Registar? (sim/não): ");
            string res = Console.ReadLine();

            string observacoes = string.Empty;
            if (res.ToLower() == "sim")
            {
                Console.Write("Informe as observações: ");
                observacoes = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nenhuma observação registada.");
            }

            Console.Write("Será prescrita Medicaççao? (sim/não): ");
            string res2 = Console.ReadLine();

            string medicacao = string.Empty;
            if (res2.ToLower() == "sim")
            {
                Console.Write("Informe a medicação: ");
                medicacao = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nenhuma Medicação prescrita!");
            }

            utente.consultas.Add(consulta);

            Console.WriteLine("Consulta registrada com sucesso!");

            Console.WriteLine("Deseja imprimir o relatório da consulta? (sim/não): ");
            string relInput = Console.ReadLine();

            if(relInput.ToLower() == "sim")
            {
                utente.RelConsultaInd();
            }
        }

    }
}
