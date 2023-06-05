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
        Concelho Concelho;
        public string Freguesia;
        List<Equipa> Equipa;
        public DateTime Data;
        public List<Rotas> ListaRotas;
      


        public Rotas(int id, string freguesia, List<Rotas> listarotas)
        {
            IdRota = id;
            Freguesia = freguesia;
            Data = DateTime.MinValue;
            ListaRotas = listarotas;
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

        public void AgendaRotas()
        { 
            Console.WriteLine("Insira o ID da rota para adicionar a data:");
            int IdRota = int.Parse(Console.ReadLine());

            // Procurar a rota com o ID fornecido
            Rotas rotas = ListaRotas.Find(r => r.IdRota == IdRota);

            if (rotas != null)
            {
                Console.WriteLine("Insira a data da rota (dd/mm/aaaa):");
                string dataString = Console.ReadLine();
                DateTime data;
                if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", null, DateTimeStyles.None, out data))
                {
                    rotas.Data = data;
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
        /*public void VerAgenda();
        {
            Console.WriteLine("Insira o ID da rota para ver a data:");
            int IdRota = int.Parse(Console.ReadLine());

            // Procurar a rota com o ID fornecido
            Rotas rotas = ListaRotas.Find(r => r.IdRota == IdRota);

            if (rotas != null)
            {
                Console.WriteLine("Data da rota: " + rotas.Data.ToString("dd/MM/yyyy"));
            }
            else
            {
                Console.WriteLine("ID da rota não encontrado!");
            }
        }*/
    }
}

