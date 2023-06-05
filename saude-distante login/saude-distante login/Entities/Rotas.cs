using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace saude_distante_login.Entities
{
    public class Rotas
    {
        public int IdRota;
        public Concelho Concelho;
        public string Freguesia;
        public List<Equipa> Equipa;
        public DateTime Data;
        public List<Rotas> Rotas;
      


        public Rotas(int id, Concelho concelho, string freguesia, List<Equipa> equipa, List<Rotas> rotas)
        {
            IdRota = id;
            Concelho = concelho;
            Freguesia = freguesia;
            Equipa = equipa;
            Data = DateTime.MinValue;
            Rotas = rotas;
        }

        public void adicionarRota(Rotas novaRota, List<Rotas> rotas)
        {
            rotas.Add(novaRota);

            rotas.Add(1, Enums.Concelho.Braga, "Sao Vitor", equipa1);
            rotas.Add(2, Enums.Concelho.Braga, "Gualtar", equipa1);
            rotas.Add(3, Enums.Concelho.Amares, "Amares e Figueiredo", equipa2);
            rotas.Add(4, Enums.Concelho.Amares, "Dornelas", equipa2);
            rotas.Add(5, Enums.Concelho.Guimarães, "Azurém", equipa3);
            rotas.Add(6, Enums.Concelho.Guimarães, "Creixomil", equipa3);
         }

        public void VerPlanoRota(List<Rotas> rotas)
        {
            foreach( Rotas r in rotas)
            {
                Console.WriteLine(r.IdRota);
                Console.WriteLine(r.Concelho);
                Console.WriteLine(r.Freguesia);
                Console.WriteLine(r.Data);
            }
        }

        public static void AgendaRotas()
        { 
            Console.WriteLine("Insira o ID da rota para adicionar a data:");
            int IdRota = int.Parse(Console.ReadLine());

            // Procurar a rota com o ID fornecido
            Rotas rota = rota.Find(r => r.IdRota == idRota);

            if (rota != null)
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

    }
}

