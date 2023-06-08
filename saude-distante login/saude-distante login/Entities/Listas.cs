
using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using saude_distante_login.Services;

namespace saude_distante_login.Entities
{
    public class Listas
    {

        List<Colaborador> Colaboradores;
        List<Utente> Utentes;
        List<Consulta> Consultas;

        public Listas()
        {
            Utentes = new List<Utente>();
            {

                Utentes.Add(new Utente("João Silva", Genero.Masculino, "123-456-7890", "Rua Sá de Noronha", Concelho.Braga, "joao.silva@example.com", 1, true));
                Utentes.Add(new Utente("Maria Santos", Genero.Feminino,"987-654-3210", "Avenida da República", Concelho.Amares, "maria.santos@example.com", 2, true));
                Utentes.Add(new Utente("Pedro Costa", Genero.Masculino, "098-765-4321", "Rua Augusta", Concelho.Guimarães, "pedro.costa@example.com", 3, true));
                Utentes.Add(new Utente("Ana Martins", Genero.Feminino, "123-456-7891", "Rua Almirante Reis", Concelho.Amares, "ana.martins@example.com", 4, true));
                Utentes.Add(new Utente("Bruno Ferreira", Genero.Masculino, "987-654-3211", "Rua de Santa Cruz", Concelho.Braga, "bruno.ferreira@example.com", 5, true));
                Utentes.Add(new Utente("Carolina Gomes", Genero.Feminino, "098-765-4322", "Avenida Central", Concelho.Guimarães, "carolina.gomes@example.com", 6, true));
                Utentes.Add(new Utente("Daniel Pereira", Genero.Masculino, "123-456-7892", "Rua do Carmo", Concelho.Braga, "daniel.pereira@example.com", 7, true));
                Utentes.Add(new Utente("Eva Rodrigues", Genero.Feminino, "987-654-3212", "Rua Garrett", Concelho.Amares, "eva.rodrigues@example.com", 8, true));
                Utentes.Add(new Utente("Fábio Fernandes", Genero.Masculino, "098-765-4323", "Rua de Santa Catarina", Concelho.Braga, "fabio.fernandes@example.com", 9, true));
                Utentes.Add(new Utente("Gabriela Lopes", Genero.Feminino, "123-456-7893", "Rua da Sofia", Concelho.Guimarães, "gabriela.lopes@example.com", 10, true));
                Utentes.Add(new Utente("Hugo Sousa", Genero.Masculino, "987-654-3213", "Avenida da Liberdade", Concelho.Braga, "hugo.sousa@example.com", 11, false));
                Utentes.Add(new Utente("Inês Almeida", Genero.Feminino, "098-765-4324", "Rua das Flores", Concelho.Guimarães, "ines.almeida@example.com", 12, true));
                Utentes.Add(new Utente("Joaquim Ribeiro", Genero.Masculino, "123-456-7894", "Rua do Rosário", Concelho.Braga, "joaquim.ribeiro@example.com", 13, true));
            };

            Colaboradores = new List<Colaborador>();
            {

                Colaboradores.Add(new Colaborador("Maria José", Genero.Feminino, "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, "123456", 1));
                Colaboradores.Add(new Colaborador("Maria José", Genero.Feminino,  "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, "123456", 2));
                Colaboradores.Add(new Colaborador("Maria José", Genero.Feminino, "912345681", "Rua Nova", Concelho.Braga, "maria.jose@email.com", 123, "Administrativo", 1100, "123456", 3));
                Colaboradores.Add(new Colaborador("Manuel Pires", Genero.Masculino, "918302038", "Rua Velha", Concelho.Amares, "manuel.pires@email.com", 124, "Motorista", 1100, "123456", 2));
                Colaboradores.Add(new Colaborador("Andreia Gomes", Genero.Feminino, "918312338", "Rua Antiga", Concelho.Amares, "andreia.gomes@email.com", 125, "Médico", 1800, "123456", 2));
                Colaboradores.Add(new Colaborador("João Silva", Genero.Masculino, "918302658", "Rua da Alegria", Concelho.Amares, "joao.silva@email.com", 126, "Enfermeiro", 1500, "123456", 2));
                Colaboradores.Add(new Colaborador("Soraia Pereira", Genero.Feminino, "918319827", "Rua 25 de Abril", Concelho.Braga, "soraia.pereira@email.com", 127, "Motorista", 1100, "123456", 1));
                Colaboradores.Add(new Colaborador("André Souto", Genero.Masculino, "915555666", "Rua Milenar", Concelho.Braga, "andre.souto@email.com", 128, "Médico", 2000, "123456", 1));
                Colaboradores.Add(new Colaborador("Clara Pinto", Genero.Feminino, "967584444", "Rua Direita", Concelho.Braga, "clara.pinto@email.com", 129, "Enfermeiro", 1000, "123456", 1));
                Colaboradores.Add(new Colaborador("Miguel Soares", Genero.Masculino, "911233454", "Rua 5 de Outubro", Concelho.Guimarães, "miguel.soares@email.com", 130, "Motorista", 1100, "123456", 3));
                Colaboradores.Add(new Colaborador("Joana Freitas", Genero.Feminino, "918111222", "Rua Velha", Concelho.Guimarães, "joana.freitas@email.com", 131, "Médico", 1500, "123456", 3));
                Colaboradores.Add(new Colaborador("Carlos Santos", Genero.Masculino,  "918891918", "Rua Santa", Concelho.Guimarães, "carlos.santos@email.com", 132, "Enfermeiro", 1500, "123456", 3));
            };

            Consultas = new List<Consulta>();
            {
                Consultas.Add(new Consulta(new DateTime(2023, 06, 08), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 1));
                Consultas.Add(new Consulta(new DateTime(2023, 05 , 20), 2, 65, 1.62, true, "N/A", 85, 122, 90, "N/A", "N/A", 2));
                Consultas.Add(new Consulta(new DateTime(2023, 05 , 23), 3, 95, 1.85, false, "N/A", 81, 119, 82, "N/A", "Artovastatina", 3));
                Consultas.Add(new Consulta(new DateTime(2023, 05 , 23), 2, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 4));
                Consultas.Add(new Consulta(new DateTime(2023, 06 , 27), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 5));
                Consultas.Add(new Consulta(new DateTime(2023, 06 , 02), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 6));
                Consultas.Add(new Consulta(new DateTime(2023, 06 , 05), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 7));
                Consultas.Add(new Consulta(new DateTime(2023, 06 , 05), 2, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Artovastatina", 8));
                Consultas.Add(new Consulta(new DateTime(2023, 06 , 05), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 9));
                Consultas.Add(new Consulta(new DateTime(2023, 06 , 20), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 10));
                Consultas.Add(new Consulta(new DateTime(2023, 06 , 20), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 11));
                Consultas.Add(new Consulta(new DateTime(2023, 06 , 08), 3, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "Aspirina", 12));
                Consultas.Add(new Consulta(new DateTime(2023, 06 , 08), 1, 80, 1.65, false, "N/A", 80, 120, 80, "N/A", "N/A", 13));
            }

        }
        public Colaborador EncontrarColaborador(string funcao, string email)
        {
            return Colaboradores.FirstOrDefault(c => c.Email == email && c.Funcao == funcao);
        }

    }
}


