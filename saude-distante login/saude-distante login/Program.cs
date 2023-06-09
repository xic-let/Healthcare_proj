using saude_distante_login.Entities;
using saude_distante_login.Entities.Enums;
using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace saude_distante_login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listas listas = new Listas();
            
            // Login
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Bem-vindo ao Saúde Menos Distante!");
            Console.WriteLine();
            Console.WriteLine("Introduza a sua Função: ");
            Console.WriteLine("1 - Médico");
            Console.WriteLine("2 - Enfermeiro");
            Console.WriteLine("3 - Administrativo");
            Console.WriteLine("4 - Motorista");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            string funcao = Console.ReadLine();

            if (funcao == "1")
            {
                funcao = "Médico";
            }
            else if (funcao == "2")
            {
                funcao = "Enfermeiro";
            }
            else if (funcao == "3")
            {
                funcao = "Administrativo";
            }
            else if (funcao == "4")
            {
                funcao = "Motorista";
            }
            else if (funcao == "5")
            {
                Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                Environment.Exit(0);
            }
            else if (funcao != "1" || funcao != "2" || funcao != "3" || funcao != "4" || funcao != "5")
            {
                Console.WriteLine("Função não reconhecida.");
                Environment.Exit(0);
            }


            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Colaborador colaboradorEncontrado = Listas.EncontrarColaborador(funcao, email);

            if (colaboradorEncontrado != null)
            {
                Console.WriteLine("Colaborador encontrado!");
                Console.WriteLine();
                switch (colaboradorEncontrado.Funcao)
                {
                    case "Médico":
                        Medico medico = new Medico();
                        medico.MostrarMenuMedico();
                        break;

                    case "Enferemeiro":
                        Enfermeiro enfermeiro = new Enfermeiro();
                        enfermeiro.MostrarMenuEnfermeiro();
                        break;

                    case "Administrativo":
                        Administrativo administrativo = new Administrativo();
                        administrativo.MostrarMenuAdministrativo();
                        break;

                    case "Motorista":
                        Motorista motorista = new Motorista();
                        motorista.MostrarMenuMotorista();
                        break;

                    default:
                        Console.WriteLine("Função não reconhecida.");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Colaborador não encontrado.");
                Environment.Exit(0);
            }

        }

    }
}
