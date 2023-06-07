using saude_distante_login.Entities;
using saude_distante_login.Entities.Enums;
using saude_distante_login.Services;
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

            
            // Login
            Console.WriteLine("Login de Colaborador:");
            Console.WriteLine();

            Console.Write("Função: ");
            string funcao = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine();

            // Verificar autenticação
            Colaborador colaboradorAutenticado = null;

            
            foreach (Colaborador colaborador in colaboradores)
            {
                if (colaborador is IAutenticacao autenticacao && autenticacao.Autenticar(funcao, email, password))
                {
                    colaboradorAutenticado = colaborador;
                    break;
                }
            }

            if (colaboradorAutenticado != null)
            {
                // Colaborador autenticado com sucesso
                Console.WriteLine("Login bem-sucedido!");
                colaboradorAutenticado.AcessoPermitido();
            }
            else
            {
                // Falha no login
                Console.WriteLine("Login falhou.Tente novamente.");
            }

        }



    }
}
