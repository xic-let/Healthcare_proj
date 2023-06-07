using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http.Headers;

namespace saude_distante_login.Entities
{
    public class Rotas
    {
        public int IdRota { get; set; }
        Concelho Concelho { get; set;}
        public string Freguesia { get; set; }
        int Equipa { get; set; }
        public DateTime Data { get; set; }  

        public Rotas() { }


        public Rotas(int id, Enums.Concelho concelho, string freguesia, int equipa, DateTime data)
        {
            IdRota = id;
            Concelho = concelho;
            Freguesia = freguesia;
            Equipa = equipa;
            Data = data;
        }

        public static List<Rotas> rotas = new List<Rotas>()
        {
            new Rotas(1, Concelho.Braga, "Sao Vitor", 1, new DateTime(2023, 1, 25)),
            new Rotas(2, Concelho.Braga, "Gualtar", 1, new DateTime(2023, 1, 25)),
            new Rotas(3, Concelho.Amares, "Amares e Figueiredo", 2, new DateTime(2023, 1, 25)),
            new Rotas(4, Concelho.Amares, "Dornelas", 2, new DateTime(2023, 1, 25)),
            new Rotas(5, Concelho.Guimarães, "Azurém", 3, new DateTime(2023, 1, 25)),
            new Rotas(6, Concelho.Guimarães, "Creixomil", 3, new DateTime(2023, 1, 25))
        };

        public static void AdicionarRota(List<Rotas> rotas)
        {
            Rotas novaRota = new Rotas();
            rotas.Add(novaRota); 
        
        }

        public void VerPlanoRota(List<Rotas> rotas)
        {
            foreach( Rotas r in rotas)
            {
                Console.WriteLine(r.IdRota);
                Console.WriteLine(r.Concelho);
                Console.WriteLine(r.Freguesia);
                Console.WriteLine(r.Equipa);
                Console.WriteLine(r.Data);
            }
        }

        public void AgendaRotas()
        { 
            Console.WriteLine("Insira o ID da rota para adicionar a data:");
            int IdRota = int.Parse(Console.ReadLine());

            // Procurar a rota com o ID fornecido
            Rotas rota = rotas.Find(r => r.IdRota == IdRota);

            if (rotas != null)
            {
                Console.WriteLine("Insira a data da rota (dd/mm/aaaa):");
                string dataString = Console.ReadLine();
                DateTime data;
                if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", null, DateTimeStyles.None, out data))
                {
                    rota.Data = data;
                    Console.WriteLine("Data adicionada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Formato de data inválido!");
                }
            }
            else
            {
                Console.WriteLine("ID da rota não encontrado!");
            }
        
        }
            public void VerAgenda()
            {
                Console.WriteLine("Insira o ID da rota para ver a data:");
                int idRota = int.Parse(Console.ReadLine());

                // Procurar a rota com o ID fornecido
                Rotas rota = rotas.Find(r => r.IdRota == idRota);

                if (rota != null)
                {
                    Console.WriteLine("Data da rota: " + rota.Data.ToString("dd/MM/yyyy"));
                }
                else
                {
                    Console.WriteLine("ID da rota não encontrado!");
                }
            }
    }
}

