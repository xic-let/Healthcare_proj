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
        public Concelho Concelho { get; set;}
        public string Freguesia { get; set; }
        public int Equipa { get; set; }
        public DateTime Data { get; set; }  

        
        public Rotas() { }


        public Rotas(int id, Concelho concelho, string freguesia, int equipa, DateTime data)
        {
            IdRota = id;
            Concelho = concelho;
            Freguesia = freguesia;
            Equipa = equipa;
            Data = data;
        }

    

        public void AdicionarRota()
        {
            List<Rotas> rotas = new List<Rotas>();

            Console.WriteLine("Insira o ID da rota:");
            int IdRota = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o concelho da rota:");
            Concelho Concelho = (Concelho)Enum.Parse(typeof(Concelho), Console.ReadLine());
            Console.WriteLine("Insira a freguesia da rota:");
            string Freguesia = Console.ReadLine();
            Console.WriteLine("Insira a equipa da rota:");
            int Equipa = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a data da rota (dd/mm/aaaa):");
            string dataString = Console.ReadLine();

            if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime data))
            {
                Data = data;
                Console.WriteLine("Data adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("Formato de data inválido!");
            }

            Rotas novaRota = new Rotas(IdRota, Concelho, Freguesia, Equipa, data);
            rotas.Add(novaRota);

            Console.WriteLine();

            Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
            string resposta = Console.ReadLine();
            if (resposta == "nao")
            {
                Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                Environment.Exit(0);
            }
            else
            {
                Motorista motorista = new Motorista();
                motorista.MostrarMenuMotorista();
            }
        }

        public void EnviarEmail()
        {
            Console.WriteLine("Insira o concelho para o qual pretende notificar os Utentes Residentes: (Braga/Amares/Guimarães)");
            string idconcelho = Console.ReadLine();

            if (Enum.TryParse<Concelho>(idconcelho, out Concelho concelho))
            {
                // Query the Utentes list for the matching Utente objects
                List<Utente> matchingUtentes = Listas.Utentes.Where(u => u.Concelho == concelho).ToList();

                if (matchingUtentes.Count > 0)
                {
                    Console.WriteLine($"Utentes Encontrados no concelho {concelho}:");
                    foreach (Utente utente in matchingUtentes)
                    {
                        string email = utente.Email;
                        Console.WriteLine($"Email enviado para: {email} ,Utente Notificado!");
                        
                    }
                }
                else
                {
                    Console.WriteLine($"Sem Utentes resgistados em: {concelho}");
                }
            }
            else
            {
                Console.WriteLine("Concelho inválido, por favor tente novamente!");
                EnviarEmail();
            }
        
        }

        public void AgendaRotas()
        { 
            Listas lista = new Listas(); // Create an instance of the Listas class
           
            Console.WriteLine("Insira o ID da rota para adicionar a data:");
            int IdRota = int.Parse(Console.ReadLine());

            // Procurar a rota com o ID fornecido
            Rotas rotaEncontrada = Listas.EncontrarRota(IdRota); 


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

            Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
            string resposta = Console.ReadLine();
            if (resposta == "nao")
            {
                Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                Environment.Exit(0);
            }
            else
            {
                Administrativo administrativo = new Administrativo();
                administrativo.MostrarMenuAdministrativo();
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

            Console.WriteLine("Deseja voltar ao menu? (sim/nao)");
            string resposta = Console.ReadLine();
            if (resposta == "nao")
            {
                Console.WriteLine("Obrigado por utilizar Saude Menos Distante. Até breve!");
                Environment.Exit(0);
            }
            else
            {
                Administrativo administrativo = new Administrativo();
                administrativo.MostrarMenuAdministrativo();
            }
        }
    }
}

