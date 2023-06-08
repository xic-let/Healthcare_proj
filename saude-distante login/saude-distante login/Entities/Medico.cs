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
    public class Medico : Colaborador
    {
        //Construtores da classe Medico

        public Medico()
        {

        }
        
        public Medico(string nome, Genero genero, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, string password, int equipa)
            : base(nome, genero, contacto, morada, concelho, email, idColaborador, funcao, vencimento, password, equipa)
        {

        }


        //Métodos da classe Medico


       /* public bool Autenticar(string funcao, string email, string password)
        {
            return base.Email == email && base.Password == password && funcao.ToLower() == "médico";
        }*/

        public void MostrarMenuMedico()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Realizar consulta");
            Console.WriteLine("2. Aceder Relatório Estatístico");
            Console.WriteLine("3. Aceder Relatório de Consultas");
            Console.WriteLine("4. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-4): ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                   
                    RegistarConsultaMed();
                    break;
                case "2":
                    
                    Utente.RelEstatistico();
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
        
        public void RegistarConsultaMed()
        { 
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Insira o Nr de Utente: ");
            int id = int.Parse(Console.ReadLine());

            // Procurar o utente na lista de utentes
            Utente utenteEncontrado = Utente.Utentes.Find(u => u.Idsns == id);


            if (utenteEncontrado == null)
            {
                Console.WriteLine("Utente não encontrado. É necessário registar o utente antes de prosseguir.");
                Console.WriteLine("Deseja registar o utente? (sim/não): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "sim")
                {
                    // Chamar o método para registrar o utente
                    Enfermeiro enfermeiro = new Enfermeiro();
                    enfermeiro.RegistoUtente();
                }
                else
                {
                    Console.WriteLine("Operação cancelada.");
                    Environment.Exit(0);
                }
            }
            else if (utenteEncontrado.Consulta == null)
            {
                Console.WriteLine("É necessário registar os dados de pré-consulta antes de prosseguir.");
                Console.WriteLine("Deseja registar os dados de pré-consulta? (sim/não): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "sim")
                {
                    Enfermeiro.RegPreConsulta();
                    Console.WriteLine("Continuar com o registo da consulta? (sim/não): ");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "sim")
                    {
                        RegistarConsultaMed();  // Chama o método novamente para continuar o registo da consulta
                    }
                    else
                    {
                        Console.WriteLine("Operação cancelada.");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Operação cancelada.");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
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

            Console.Write("Será prescrita Medicaçao? (sim/não): ");
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

            utenteEncontrado.Consulta.Fumador = fumador;
            utenteEncontrado.Consulta.HistoricoDoencas = historicoDoencas;
            utenteEncontrado.Consulta.Observacoes = observacoes;
            utenteEncontrado.Consulta.Receitas = medicacao;

            Console.WriteLine("Consulta registada com sucesso!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Deseja imprimir o relatório da consulta? (sim/não): ");
            string relInput = Console.ReadLine();

            if(relInput.ToLower() == "sim" || relInput.ToLower() == "s")
            {
                Enfermeiro enfermeiro = new Enfermeiro();
                enfermeiro.ImprimefichaUtente();
                Utente.RelConsultaInd();
            }
            else
            {
                Console.WriteLine("Operação cancelada.");
                Environment.Exit(0);
            }
        }

    }
}
