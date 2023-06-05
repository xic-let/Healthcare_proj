using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    internal class Colaborador : Pessoa
    {
        public int IdColaborador { get; private set; }
        public double Vencimento { get; set; }
        public string Password { get; private set; }
        public Equipa Equipa { get; set; }
        public List<Equipa> Equipas { get; set; } = new List<Equipa>();

        public Colaborador()
        {

        }

        
        public Colaborador(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, double vencimento, Equipa equipa, string password)
            : base(nome, genero, dataNascimento, contacto, morada, concelho, email)
        {
            IdColaborador = idColaborador;
            Vencimento = vencimento;
            Equipa = equipa;
            Password = password;
        }

        //Métodos da classe Colaborador
        public virtual void AcessoPermitido()
        {
            Console.WriteLine("Bem-vindo/a " + this.Nome);
            Console.WriteLine();
        }

        public void RelConsultas()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("DGS - Direção Regional de Saude de Rastreios");
            Console.WriteLine();
            Console.WriteLine("Relatório Diário de Rastreios");
            Console.WriteLine("Data: " + DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Numero Total de Consultas Realizadas: " + //aplicar .Count para contar o numero de consultas realizadas);
            Console.WriteLine("Numero de consultas realizadas por Rota: " + //sortir as consultas por equipa e contar ccada uma delas);
            Console.WriteLine();
            Console.WriteLine("Análise de Risco de Tensão Arterial dos Utentes");
            Console.WriteLine("Numero de Utentes com Indice HTA grau I: " + //aplicar .Count para contar o numero de utentes com indice HTA grau I);
            Console.WriteLine("Utentes com Indice HTA grau I: " + //Imprimir os utentes com indice HTA grau I);
            Console.WriteLine("Numero de Utentes com Indice HTA grau II: " + //aplicar .Count para contar o numero de utentes com indice HTA grau II);
            Console.WriteLine("Utentes com Indice HTA grau II: " + //Imprimir os utentes com indice HTA grau II);
            Console.WriteLine("Numero de Utentes com Indice HTA grau III: " + //aplicar .Count para contar o numero de utentes com indice HTA grau III);
            Console.WriteLine("Utentes com Indice HTA grau III: " + //Imprimir os utentes com indice HTA grau III);
            Console.WriteLine();
            Console.WriteLine("Análise de Risco de Diabetes dos Utentes");
            Console.WriteLine("Numero de Utentes com Indice Diabetes grau I: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau I);
            Console.WriteLine("Utentes com Indice Diabetes grau I: " + //Imprimir os utentes com Diabetes grau I);
            Console.WriteLine("Numero de Utentes com Indice Diabetes grau II: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau II);
            Console.WriteLine("Utentes com Indice Diabetes grau II: " + //Imprimir os utentes com Diabetes grau II);
            Console.WriteLine("Numero de Utentes com Indice Diabetes grau III: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau III);
            Console.WriteLine("Utentes com Indice Diabetes grau III: " + //Imprimir os utentes com Diabetes grau III);
            Console.WriteLine();
            Console.WriteLine("Análise de Risco de Obesidade dos Utentes");
            Console.WriteLine("Numero de Utentes com Indice Obesidade grau I " + //aplicar .Count para contar o numero de utentes com indice Obesidade grau I);
            Console.WriteLine("Utentes com Indice Obesidade Grau I: " + //Imprimir os utentes com Obesidade grau I);
            Console.WriteLine("Numero de Utentes com Indice Obesidade grau II " + //aplicar .Count para contar o numero de utentes com indice Obesidade grau II);
            Console.WriteLine("Utentes com Indice Obesidade grau II: " + //Imprimir os utentes com Diabetes grau II);
            Console.WriteLine("-------------------------------------------------"



        }

        public void RelEstatistico()
        {   
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("DGS - Direção Regional de Saude de Rastreios");
            Console.WriteLine();
            Console.WriteLine("Relatório Estatistico de Rastreios");
            Console.WriteLine("Data: " + DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Numero Total de Consultas Realizadas: " + //aplicar .Count para contar o numero de consultas realizadas);
            Console.WriteLine("Numero de consultas realizadas por Rota: " + //sortir as consultas por equipa e contar ccada uma delas);
            Console.WriteLine();
            Console.WriteLine("Análise de Risco de Tensão Arterial dos Utentes");
            Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau I: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau I);
            Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau II: " + //aplicar .Count para contar o numero de utentes com indice Diabetes grau II);
            Console.WriteLine("Percentagem de Utentes com Indice HTA grau III: " + //Imprimir os utentes com indice HTA grau III);
            Console.WriteLine();
            Console.WriteLine("Análise de Risco de Diabetes dos Utentes");
            Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau I: " + //Imprimir os utentes com Diabetes grau I);
            Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau II: " + //Imprimir os utentes com Diabetes grau II);
            Console.WriteLine("Percentagem de Utentes com Indice Diabetes grau III: " + //Imprimir os utentes com Diabetes grau III);
            Console.WriteLine();
            Console.WriteLine("Análise de Risco de Obesidade dos Utentes");
            Console.WriteLine("Percentagem  de Utentes com Indice Obesidade grau I " + //aplicar .Count para contar o numero de utentes com indice Obesidade grau I);
            Console.WriteLine("Percentagem de Utentes com Indice Obesidade grau II " + //aplicar .Count para contar o numero de utentes com indice Obesidade grau II);
            Console.WriteLine("-------------------------------------------------"

        }


    }
}
