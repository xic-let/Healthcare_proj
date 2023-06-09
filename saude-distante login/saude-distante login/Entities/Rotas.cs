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

    

        public void AdicionarRota(int id, Enums.Concelho concelho, string freguesia, int equipa, DateTime data)
        {
            List<Rotas> rotas = new List<Rotas>();
            Rotas novaRota = new Rotas(id, concelho, freguesia, equipa, data);
            Console.WriteLine("Insira o ID da rota:");
            novaRota.IdRota = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o concelho da rota:");
            novaRota.Concelho = (Concelho)Enum.Parse(typeof(Concelho), Console.ReadLine());
            Console.WriteLine("Insira a freguesia da rota:");
            novaRota.Freguesia = Console.ReadLine();
            Console.WriteLine("Insira a equipa da rota:");
            novaRota.Equipa = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a data da rota (dd/mm/aaaa):");
            string dataString = Console.ReadLine();
          
            if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", null, DateTimeStyles.None, out data))
            {
                novaRota.Data = data;
                Console.WriteLine("Data adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("Formato de data inválido!");
            }
            rotas.Add(novaRota);
        }

        public static void VerPlanoRota(List<Rotas> rotas)
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
            Listas lista = new Listas(); // Create an instance of the Listas class
           
            Console.WriteLine("Insira o ID da rota para adicionar a data:");
            int IdRota = int.Parse(Console.ReadLine());

            // Procurar a rota com o ID fornecido
            Rotas rotaEncontrada = Listas.EncontrarRota(IdRota); // Call the EncontrarRota method on the instance


            if (rotaEncontrada != null)
            {
                Console.WriteLine("Insira a data da rota (dd/mm/aaaa):");
                string dataString = Console.ReadLine();
                DateTime data;
                if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", null, DateTimeStyles.None, out data))
                {
                    rotaEncontrada.Data = data;
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
                Listas lista = new Listas(); // Create an instance of the Listas class
                Console.WriteLine("Insira o ID da rota para ver a data:");
                int idRota = int.Parse(Console.ReadLine());

                // Procurar a rota com o ID fornecido
                Rotas rotaencontrada = Listas.EncontrarRota(idRota);

                if (rotaencontrada != null)
                {
                    Console.WriteLine("Data da rota: " + rotaencontrada.Data.ToString("dd/MM/yyyy"));
                }
                else
                {
                    Console.WriteLine("ID da rota não encontrado!");
                }
            }
    }
}

