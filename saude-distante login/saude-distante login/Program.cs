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

            //Lista Utentes
            List<Utente> utentes = new List<Utente>(new Utente[]
            {
                new Utente("João Silva", Genero.Masculino, new DateTime(06-06-1975), "123-456-7890", "Rua Sá de Noronha", Concelho.Braga, "joao.silva@example.com", 1, true),
                new Utente("Maria Santos", Genero.Feminino, new DateTime(02-02-1980), "987-654-3210", "Avenida da República", Concelho.Amares, "maria.santos@example.com", 2, true),
                new Utente("Pedro Costa", Genero.Masculino, new DateTime(05-05-1985), "098-765-4321", "Rua Augusta", Concelho.Guimarães, "pedro.costa@example.com", 3, true),
                new Utente("Ana Martins", Genero.Feminino, new DateTime(01-01-1955), "123-456-7891", "Rua Almirante Reis", Concelho.Amares, "ana.martins@example.com", 4, true),
                new Utente("Bruno Ferreira", Genero.Masculino, new DateTime(02-02-1960), "987-654-3211", "Rua de Santa Cruz", Concelho.Braga, "bruno.ferreira@example.com", 5, true),
                new Utente("Carolina Gomes", Genero.Feminino, new DateTime(03-03-1965), "098-765-4322", "Avenida Central", Concelho.Guimarães, "carolina.gomes@example.com", 6, true),
                new Utente("Daniel Pereira", Genero.Masculino, new DateTime(04-04-1969), "123-456-7892", "Rua do Carmo", Concelho.Braga, "daniel.pereira@example.com", 7, true),
                new Utente("Eva Rodrigues", Genero.Feminino, new DateTime(05-05-1970), "987-654-3212", "Rua Garrett", Concelho.Amares, "eva.rodrigues@example.com", 8, true),
                new Utente("Fábio Fernandes", Genero.Masculino, new DateTime(02-02-1950), "098-765-4323", "Rua de Santa Catarina", Concelho.Braga, "fabio.fernandes@example.com", 9, true),
                new Utente("Gabriela Lopes", Genero.Feminino, new DateTime(07-07-1951), "123-456-7893", "Rua da Sofia", Concelho.Guimarães, "gabriela.lopes@example.com", 10, true),
                new Utente("Hugo Sousa", Genero.Masculino, new DateTime(08-08-1954), "987-654-3213", "Avenida da Liberdade", Concelho.Braga, "hugo.sousa@example.com", 11, false),
                new Utente("Inês Almeida", Genero.Feminino, new DateTime(09-09-1962), "098-765-4324", "Rua das Flores", Concelho.Guimarães, "ines.almeida@example.com", 12, true),
                new Utente("Joaquim Ribeiro", Genero.Masculino, new DateTime(10-10-1964), "123-456-7894", "Rua do Rosário", Concelho.Braga, "joaquim.ribeiro@example.com", 13, true)
            });

            //Lista Colaboradores
            List<Colaborador> colaboradores = new List<Colaborador>(new Colaborador[]
            {
               new Colaborador("Maria José", Genero.Feminino, new DateTime(11-11-1987), "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, /*nao sei o que por na equipa*/, "123456"),
               new Colaborador("Manuel Pires", Genero.Masculino, new DateTime(12-12-1977), "918302038", "Rua Velha", Concelho.Amares, "manuel.pires@email.com", 124, "Motorista", 1100, /*nao sei o que por na equipa*/, "123456"),
               new Colaborador("Andreia Gomes", Genero.Feminino, new DateTime(01-12-1979), "918312338", "Rua Antiga", Concelho.Amares, "andreia.gomes@email.com", 125, "Médico", 1800, /*nao sei o que por na equipa*/, "123456"),
               new Colaborador("João Silva", Genero.Masculino, new DateTime(12-12-1990), "918302658", "Rua da Alegria", Concelho.Amares, "joao.silva@email.com", 126, "Enfermeiro", 1500, /*nao sei o que por na equipa*/, "123456"),
               new Colaborador("Soraia Pereira", Genero.Feminino, new DateTime(12-01-1969), "918319827", "Rua 25 de Abril", Concelho.Braga, "soraia.pereira@email.com", 127, "Motorista", 1100, /*nao sei o que por na equipa*/, "123456"),
               new Colaborador("André Souto", Genero.Masculino, new DateTime(02-12-1979), "915555666", "Rua Milenar", Concelho.Braga, "andre.souto@email.com", 128, "Médico", 2000, /*nao sei o que por na equipa*/, "123456"),
               new Colaborador("Clara Pinto", Genero.Feminino, new DateTime(03-12-1991), "967584444", "Rua Direita", Concelho.Braga, "clara.pinto@email.com", 129, "Enfermeiro", 1000, /*nao sei o que por na equipa*/, "123456"),
               new Colaborador("Miguel Soares", Genero.Masculino, new DateTime(04-12-1974), "911233454", "Rua 5 de Outubro", Concelho.Guimarães, "miguel.soares@email.com", 130, "Motorista", 1100, /*nao sei o que por na equipa*/, "123456"),
               new Colaborador("Joana Freitas", Genero.Feminino, new DateTime(05-05-1988), "918111222", "Rua Velha", Concelho.Guimarães, "joana.freitas@email.com", 131, "Médico", 1500, /*nao sei o que por na equipa*/, "123456"),
               new Colaborador("Carlos Santos", Genero.Masculino, new DateTime(12-12-1987), "918891918", "Rua Santa", Concelho.Guimarães, "carlos.santos@email.com", 132, "Enfermeiro", 1500, /*nao sei o que por na equipa*/, "123456")
            });

            //Lista Consultas
            List<Consulta> consultas = new List<Consulta>(new Consulta[]
            {
                new Consulta(new DateTime(20-05-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", utente, consulta),
                new Consulta(new DateTime(20-05-2023), equipa, 65, 1.62, true, "N/A", 85, 122, 90, "N/A", "N/A", utente, consulta),
                new Consulta(new DateTime(27-05-2023), equipa, 95, 1.85, false, "N/A", 81, 119, 82, "N/A", "Artovastatina", utente, consulta),
                new Consulta(new DateTime(27-05-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", utente, consulta),
                new Consulta(new DateTime(01-06-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", utente, consulta),
                new Consulta(new DateTime(02-06-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", utente, consulta),
                new Consulta(new DateTime(05-06-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", utente, consulta),
                new Consulta(new DateTime(05-06-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Artovastatina", utente, consulta),
                new Consulta(new DateTime(05-06-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", utente, consulta),
                new Consulta(new DateTime(06-06-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", utente, consulta),
                new Consulta(new DateTime(07-06-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", utente, consulta),
                new Consulta(new DateTime(08-06-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", utente, consulta),
                new Consulta(new DateTime(08-06-2023), equipa, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", utente, consulta)
            });

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
