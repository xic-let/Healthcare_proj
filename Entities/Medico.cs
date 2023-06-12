using Microsoft.VisualBasic;
using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using OfficeOpenXml;
using System.IO;


namespace saude_distante_login.Entities
{
    public class Medico : Colaborador
    {
        //Construtores da classe Medico

        public Medico()
        {

        }
        
        public Medico(string nome, Genero genero, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, string password, int equipa)
            : base(nome, genero, contacto, morada, concelho, email, idColaborador, funcao, vencimento, equipa)
        {

        }


        //Métodos da classe Medico


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
                    RelConsultas();
                    break;
                case "3":                    
                    Utente.RelEstatistico();
                    break;
                case "4":
                    Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }
        
        public void RegistarConsultaMed()
        { 
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Insira o Nr de Utente: ");
            int id = int.Parse(Console.ReadLine());

            // Procurar o utente na lista de utentes
            Utente utenteEncontrado = Listas.Utentes.Find(u => u.Idsns == id);
            

            if (utenteEncontrado == null)
            {
                Console.WriteLine("Utente não encontrado. É necessário registar o utente antes de prosseguir.");
                Console.WriteLine("Deseja registar o utente? (sim/não): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "sim" || input.ToLower() == "s" || input.ToLower() == "SIM" || input.ToLower() == "S")
                {
                    // Chamar o método para registar o utente
                    Enfermeiro enfermeiro = new Enfermeiro();
                    enfermeiro.RegistoUtente();
                    Enfermeiro.RegPreConsulta();
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
                        MostrarMenuMedico();
                    }
                    
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
                        Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
                        string resposta = Console.ReadLine();
                        if (resposta == "nao")
                        {
                            Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            MostrarMenuMedico();
                        }
                    }
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
                        MostrarMenuMedico();
                    }
                }
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Registe os dados da consulta:");

            Console.Write("É fumador? (sim/nao): ");
            bool fumador;
            string resp = Console.ReadLine().ToLower();
            if (resp == "sim")
            {
                fumador = true;
            }
            else
            {
                fumador = false;
            }

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

            string receitas = string.Empty;
            if (res2.ToLower() == "sim")
            {
                Console.Write("Informe a medicação: ");
                receitas = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nenhuma medicação prescrita!");
            }

            Consulta Consulta = new Consulta(fumador, historicoDoencas, observacoes, receitas, id);
            Listas.Consultas.Add(utenteEncontrado.Consulta);

            utenteEncontrado.Consulta.Fumador = fumador;
            utenteEncontrado.Consulta.HistoricoDoencas = historicoDoencas;
            utenteEncontrado.Consulta.Observacoes = observacoes;
            utenteEncontrado.Consulta.Receitas = receitas;
            utenteEncontrado.Consulta.Idsns = id;

           

            Console.WriteLine("Consulta registada com sucesso!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Deseja imprimir o relatório da consulta? (sim/não): ");
            string relInput = Console.ReadLine();

            if(relInput.ToLower() == "sim" || relInput.ToLower() == "s")
            {
                Enfermeiro enfermeiro = new Enfermeiro();
                enfermeiro.ImprimefichaUtente();


                List<Utente> listaUtentes = new List<Utente>();
                List<Consulta> listaConsultas = new List<Consulta>();
                Utente.RelConsultaInd(listaUtentes, listaConsultas);

                Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Deseja voltar ao menu principal? (sim/não): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "sim" || input.ToLower() == "s")
                {
                    MostrarMenuMedico();
                }
                else
                {
                    Console.WriteLine("Operação cancelada.");
                    Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                    Environment.Exit(0);
                }
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
                    MostrarMenuMedico();
                }
            }
        }

    }
}
