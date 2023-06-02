using System;

public class Admin : Colaborador
{
    
    
    public Admin()
    {

    }

    //public Colaborador(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, int idColaborador, Equipa equipa, funcaoProfissional tipoColab, double vencimento, string password)
    public Admin(double vencimento, char equipa, string viatura)
        :base(vencimento, equipa, viatura)
    {

    }

    public void AddItemInventario(ItemInventario item)
    {
        inventario.Add(item);
    }

    public void RegistoColaborador(List<Colaborador> colaboradores, Colaborador novoColaborador)
    {
        // Verificação se o colaborador é do tipo administrativo
        if (TipoColab != TipoColaborador.Administrativo)
        {
            Console.WriteLine("Apenas o administrativo pode adicionar novos colaboradores.");
            return;
        }

        colaboradores.Add(novoColaborador);
        Console.WriteLine("Novo colaborador adicionado com sucesso!");
    }

    public void RegistoEquipa(List<Equipa> equipas, Equipa novaEquipa)
    {
        //Verificação se o colaborador é do tipo administrativo
        if (TipoColab != TipoColaborador.Administrativo)
        {
            Console.WriteLine("Apenas o administrativo pode criar novas equipas.");
            return;
        }

        equipas.Add(novaEquipa);
        Console.WriteLine("Nova equipa criada com sucesso!");
    }

    /*public void RegistoColaborador()
    {
        Console.WriteLine("Registo de Utilizador");
        Console.WriteLine();
        Console.Write("Nome: ");
        Nome = Console.ReadLine();
        Console.Write("Email: ");
        Email = Console.ReadLine();
        Console.Write("Password: ");
        Password = Console.ReadLine();
        Console.Write("Data de Nascimento: ");
        DataNascimento = DateTime.Parse(Console.ReadLine());
        Console.Write("Morada: ");
        Morada = Console.ReadLine();
        Console.WriteLine("Concelho: ");
        Concelho = Console.ReadLine();
        Console.WriteLine("Contacto: ");
        Contacto = int.Parse(Console.ReadLine());
        Console.WriteLine("Dá o seu consentimento para tratamento dos dados de acordo com o RGPD? (Sim/Nao)");
        string resp = Console.ReadLine();

        if (resp == "Sim")
        {
            Console.WriteLine("Utilizador Registado com Sucesso!");
        }
        else
        {
            Console.WriteLine("O registo não pode ser efetuado!");
        }*/


}
}
