using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace saude_distante_login.Entities
{
    internal class Equipa
    {

        //Propriedades da classe Equipa
        public int IdEquipa { get; set; }
        public Distrito Distrito { get; set; }
        public Administrativo Administrativo { get; set; }
        public Motorista Motorista { get; set; }
        public Medico Medico { get; set; }
        public Enfermeiro Enfermeiro { get; set; }
        public Equipamentos Equipamentos { get; set; }

        //Construtores da classe Equipa

        public Equipa(int idEquipa, Distrito distrito, Administrativo administrativo, Motorista motorista, Medico medico, Enfermeiro enfermeiro, Equipamentos equipamentos)
        {
            IdEquipa = idEquipa;
            Distrito = distrito;
            Administrativo = administrativo;
            Motorista = motorista;
            Medico = medico;
            Enfermeiro = enfermeiro;
            Equipamentos = equipamentos;

        }
        
        public AddEquipa()
        {
            Console.WriteLine("Insira o ID da equipa: ");
            int idEquipa = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o distrito: ");
            string distrito = Console.ReadLine();
            Console.WriteLine("Insira o nome do administrativo: ");
            string nomeAdministrativo = Console.ReadLine();
            Console.WriteLine("Insira o nome do motorista: ");
            string nomeMotorista = Console.ReadLine();
            Console.WriteLine("Insira o nome do médico: ");
            string nomeMedico = Console.ReadLine();
            Console.WriteLine("Insira o nome do enfermeiro: ");
            string nomeEnfermeiro = Console.ReadLine();
            Console.WriteLine("Insira o nome do equipamento: ");
            string nomeEquipamento = Console.ReadLine();

            Equipa equipa = new Equipa(idEquipa, distrito, nomeAdministrativo, nomeMotorista, nomeMedico, nomeEnfermeiro, nomeEquipamento);
        }
    }
}

