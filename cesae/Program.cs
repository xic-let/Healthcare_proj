using Saude_distante.Entities;
using Saude_distante.Entities.Enums;

namespace Saude_distante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            Colaborador colaborador1 = new Colaborador(funcaoProfissional.Administrativo, "maria@email.com", "12345");

            Console.WriteLine("Login de Colaborador");
            Console.WriteLine();
            Console.WriteLine("Selecione a sua Função: Administrativo, Enfermeiro, Médico, Motorista");
            string inserirFuncao = Console.ReadLine().ToLower();

            if (Enum.TryParse<funcaoProfissional>(inserirFuncao, out funcaoProfissional tipoColab)) //Enum.TryParse<TipoColaborador> é um método que tenta converter uma string em um enumerador anteriormente especificado
            {
                Console.Write("Email: ");
                string inserirEmail = Console.ReadLine();
                Console.Write("Password: ");
                string inserirPassword = Console.ReadLine();

                Colaborador colaboradorLogin = null;

                //verificação se o colaborador existe e validação das credenciais
                foreach (Colaborador colaborador in colaboradores) 
                {
                    if (colaborador.TipoColab == tipoColab && colaborador.Email == inserirEmail && colaborador.Password == inserirPassword)
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
                        case funcaoProfissional.Administrativo:
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
            }    
            else
            {
                Console.WriteLine("Função não encontrada. Tente novamente.");
            }     

            
        }


    }
}
