﻿using saude_distante_login.Entities;
using saude_distante_login.Entities.Enums;
using System.Diagnostics.Contracts;

namespace saude_distante_login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Administrativo administrativo = new Colaborador("Maria José", Genero.Feminino, new DateTime(02 - 05 - 1985), "934567654", "Rua das Flores nº5", Distrito., "maria.jose@email.com", 123, 1000, "123456");
            Console.WriteLine("Login de Colaborador");
            Console.WriteLine();
            Console.WriteLine("Selecione a sua Função (1-4):");
            Console.WriteLine("1-Administrativo");
            Console.WriteLine("2-Enfermeiro");
            Console.WriteLine("3-Médico");
            Console.WriteLine("4-Motorista");

            string lerColaborador = Console.ReadLine();
            Colaborador colaboradorLogin = null;

            switch (lerColaborador)
            {
                case "1":
                    LoginAdministrativo(colaboradores);
                    break;
                case "2":
                    LoginEnfermeiro(colaboradores);
                    break;
                case "3":
                    LoginMedico(colaboradores);
                    break;
                case "4":
                    LoginMotorista(colaboradores);
                    break;
                default:
                    Console.WriteLine("Opção Inválida. Tente novamente.");
                    break;
            }

            Console.Write("Email: ");
            string inserirEmail = Console.ReadLine();
            Console.Write("Password: ");
            string inserirPassword = Console.ReadLine();

            Colaborador colaboradorLogin = null;

            //verificação se o colaborador existe e validação das credenciais
            foreach (Colaborador colaborador in colaboradores)
            {
                if (colaborador.Email == inserirEmail && colaborador.Password == inserirPassword)
                {
                    colaboradorLogin = colaborador;
                    break;
                }
            }

            if (colaboradorLogin != null)
            {
                Console.WriteLine("Login efetuado com sucesso!");

                switch (colaboradorLogin.TipoColab)
                {
                    case Administrativo:
                        Console.WriteLine("Menu Administrativo:");
                        Console.WriteLine("1. Adicionar novo colaborador");
                        Console.WriteLine("2. Gerar relatório de colaborador");
                        Console.WriteLine("3. Gerar relatório diário");
                        Console.WriteLine("4. Gerar relatório estatístico");
                        Console.WriteLine("5. Agendar Rota");
                        break;

                    case funcaoProfissional.Enfermeiro:
                        Console.WriteLine("Menu Enfermeiro:");
                        Console.WriteLine("1. Registo de utente");
                        Console.WriteLine("2. Emitir relatório de consultas");
                        Console.WriteLine("3. Gerar relatório estatístico");

                        break;

                    case funcaoProfissional.Médico:
                        Console.WriteLine("Menu Médico:");
                        Console.WriteLine("1. Realizar consulta");
                        Console.WriteLine("2. Emitir relatório de consultas");
                        Console.WriteLine("3. Gerar relatório estatístico");
                        break;


                    case funcaoProfissional.Motorista:
                        Console.WriteLine("Menu Motorista:");
                        Console.WriteLine("1. Verificar plano de rota");
                        Console.WriteLine("2. Emitir relatório de consultas");
                        Console.WriteLine("3. Gerar relatório estatístico");
                        // Adicionar mais opções para Motorista, se necessário
                        break;

                    default:
                        Console.WriteLine("Função não reconhecida. Opções indisponíveis.");
                        break;
                }

                //Resto do código
            }

            else
            {
                Console.WriteLine("Função, Email ou Password inválidos. Tente novamente.");
            }


                else
            {
                Console.WriteLine("Função não encontrada. Tente novamente.");
            }


            //teste métodos administrativo          
            /*
            Console.OutputEncoding = System.Text.Encoding.Default;  //permite imprimir na consola o símbolo €. caso contrário imprime ?
            
            Administrativo administrativo = new Administrativo();
            
            administrativo.RegistarEquipa(administrativo);

            Console.WriteLine();

            administrativo.RegistarEquipa(administrativo);

            Console.WriteLine();

            administrativo.RelatorioColaboradores();

            administrativo.RelatorioEquipa(2);
            */
            
        }



    }
}