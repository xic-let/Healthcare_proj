using System;

public class ProfissionalSaude : Colaborador
{
    public ProfissionalSaude()
    {

    }

    public ProfissionalSaude(double vencimento, char equipa, string viatura)
        :base(vencimento, equipa, viatura)
    {

    }

    
    public AddDadosSaude(DadosSaude dados)
    {
        dadoutente.Add(dados);
    }
  
}
