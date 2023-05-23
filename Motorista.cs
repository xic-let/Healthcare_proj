using System;

public class Motorista : Colaborador
{
    public List<Rota> rotas = new List<Rota>();

    
    public Motorista()
    {
        
    }

    public Motorista(double vencimento, char equipa, string viatura)
        :base(vencimento, equipa, viatura)
    { 
        
    }

    
    public void AddRota(Rota rota)
    {
        rotas.Add(rota);
    }
}
