
using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;


namespace saude_distante_login.Entities
{
    public class Listas
    {


        public static List<Utente> Utentes { get; } = new List<Utente>
            {

                new Utente("Maria Santos", Genero.Feminino,"987-654-3210", "Avenida da República", Concelho.Amares, "maria.santos@example.com", 2, true),
                new Utente("Pedro Costa", Genero.Masculino, "098-765-4321", "Rua Augusta", Concelho.Guimarães, "pedro.costa@example.com", 3, true),
                new Utente("Ana Martins", Genero.Feminino, "123-456-7891", "Rua Almirante Reis", Concelho.Amares, "ana.martins@example.com", 4, true),
                new Utente("Bruno Ferreira", Genero.Masculino, "987-654-3211", "Rua de Santa Cruz", Concelho.Braga, "bruno.ferreira@example.com", 5, true),
                new Utente("Carolina Gomes", Genero.Feminino, "098-765-4322", "Avenida Central", Concelho.Guimarães, "carolina.gomes@example.com", 6, true),
                new Utente("Daniel Pereira", Genero.Masculino, "123-456-7892", "Rua do Carmo", Concelho.Braga, "daniel.pereira@example.com", 7, true),
                new Utente("Eva Rodrigues", Genero.Feminino, "987-654-3212", "Rua Garrett", Concelho.Amares, "eva.rodrigues@example.com", 8, true),
                new Utente("Fábio Fernandes", Genero.Masculino, "098-765-4323", "Rua de Santa Catarina", Concelho.Braga, "fabio.fernandes@example.com", 9, true),
                new Utente("Gabriela Lopes", Genero.Feminino, "123-456-7893", "Rua da Sofia", Concelho.Guimarães, "gabriela.lopes@example.com", 10, true),
                new Utente("Hugo Sousa", Genero.Masculino, "987-654-3213", "Avenida da Liberdade", Concelho.Braga, "hugo.sousa@example.com", 11, false),
                new Utente("Inês Almeida", Genero.Feminino, "098-765-4324", "Rua das Flores", Concelho.Guimarães, "ines.almeida@example.com", 12, true),
                new Utente("Joaquim Ribeiro", Genero.Masculino, "123-456-7894", "Rua do Rosário", Concelho.Braga, "joaquim.ribeiro@example.com", 13, true)
            };

        public static List<Colaborador> Colaboradores { get; } = new List<Colaborador>
            {

                new Colaborador("Maria José", Genero.Feminino, "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, 1),
                new Colaborador("Maria José", Genero.Feminino,  "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, 2),
                new Colaborador("Maria José", Genero.Feminino, "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, 3),
                new Colaborador("Manuel Pires", Genero.Masculino, "918302038", "Rua Velha", Concelho.Amares, "manuel.pires@email.com", 124, "Motorista", 1100, 2),
                new Colaborador("Andreia Gomes", Genero.Feminino, "918312338", "Rua Antiga", Concelho.Amares, "andreia.gomes@email.com", 125, "Médico", 1800, 2),
                new Colaborador("João Silva", Genero.Masculino, "918302658", "Rua da Alegria", Concelho.Amares, "joao.silva@email.com", 126, "Enfermeiro", 1500, 2),
                new Colaborador("Soraia Pereira", Genero.Feminino, "918319827", "Rua 25 de Abril", Concelho.Braga, "soraia.pereira@email.com", 127, "Motorista", 1100, 1),
                new Colaborador("André Souto", Genero.Masculino, "915555666", "Rua Milenar", Concelho.Braga, "andre.souto@email.com", 128, "Médico", 2000, 1),
                new Colaborador("Clara Pinto", Genero.Feminino, "967584444", "Rua Direita", Concelho.Braga, "clara.pinto@email.com", 129, "Enfermeiro", 1000, 1),
                new Colaborador("Miguel Soares", Genero.Masculino, "911233454", "Rua 5 de Outubro", Concelho.Guimarães, "miguel.soares@email.com", 130, "Motorista", 1100, 3),
                new Colaborador("Joana Freitas", Genero.Feminino, "918111222", "Rua Velha", Concelho.Guimarães, "joana.freitas@email.com", 131, "Médico", 1500, 3),
                new Colaborador("Carlos Santos", Genero.Masculino,  "918891918", "Rua Santa", Concelho.Guimarães, "carlos.santos@email.com", 132, "Enfermeiro", 1500, 3),
            };

        public static List<Consulta> Consultas { get; } = new List<Consulta>
            {
                new Consulta(new DateTime(2023, 06, 08), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 1),
                new Consulta(new DateTime(2023, 05 , 20), 2, 65, 1.62, true, "N/A", 85, 122, 90, "N/A", "N/A", 2),
                new Consulta(new DateTime(2023, 05 , 23), 3, 95, 1.85, false, "N/A", 81, 119, 82, "N/A", "Artovastatina", 3),
                new Consulta(new DateTime(2023, 05 , 23), 2, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 4),
                new Consulta(new DateTime(2023, 06 , 07), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 5),
                new Consulta(new DateTime(2023, 06 , 02), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 6),
                new Consulta(new DateTime(2023, 06 , 05), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 7),
                new Consulta(new DateTime(2023, 06 , 05), 2, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Artovastatina", 8),
                new Consulta(new DateTime(2023, 06 , 05), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 9),
                new Consulta(new DateTime(2023, 05 , 20), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 10),
                new Consulta(new DateTime(2023, 05 , 20), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 11),
                new Consulta(new DateTime(2023, 05 , 08), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 13),
            };

        public static List<Rotas> rotas { get; } = new List<Rotas>
            {
              new Rotas(1, Concelho.Braga, "Sao Vitor", 1, new DateTime(2023, 5, 25,  09, 00, 00)),
              new Rotas(2, Concelho.Braga, "Gualtar", 1, new DateTime(2023, 5, 26, 09, 00, 00)),
              new Rotas(3, Concelho.Amares, "Amares e Figueiredo", 2, new DateTime(2023, 5, 25,  09, 00, 00)),
              new Rotas(4, Concelho.Amares, "Dornelas", 2, new DateTime(2023, 5, 26,  09, 00, 00)),
              new Rotas(5, Concelho.Guimarães, "Azurém", 3, new DateTime(2023, 5, 25,  09, 00, 00)),
              new Rotas(6, Concelho.Guimarães, "Creixomil", 3, new DateTime(2023, 5, 26, 09, 00, 00))
            };


        public static Rotas EncontrarRota(int idRota)
        {
            var rota = Listas.rotas.FirstOrDefault(r => r.IdRota == idRota);
            /*if (rota == null)
            {
                throw new InvalidOperationException($"Não foi encontrada uma rota com o ID {idRota}.");
            }*/
            return rota;
        }

        public static Colaborador EncontrarColaborador(string funcao, string email)
        {
            var colaborador = Listas.Colaboradores.FirstOrDefault(c => c.Email == email && c.Funcao == funcao);
            if(colaborador == null)
            {
                throw new InvalidOperationException($"Não foi encontrado um colaborador com a função '{funcao}' e o e-mail '{email}'.");
            }
            return colaborador;
        }


        public static Utente EncontrarUtente(int Idsns)
        {
            var utente = Listas.Utentes.FirstOrDefault(u => u.Idsns == Idsns);
            if (utente == null)
            {
                throw new InvalidOperationException($"Não foi encontrado um utente com o ID SNS '{Idsns}'.");
            }
            return utente;
        }

    }

}



