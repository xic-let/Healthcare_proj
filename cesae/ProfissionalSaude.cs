using System;

public class Enfermeiro : Colaborador
{
   
    public Enfermeiro(string nome, Genero genero, DateTime dataNascimento, string contacto, string morada, Concelho concelho, string email, string password, int idColaborador, Equipa equipa, double vencimento, string especialidade)
        : base(nome, genero, dataNascimento, contacto, morada, concelho, email, idColaborador, equipa, tipoColab, vencimento, password)
    {
        Especialidade = especialidade;
    }

    protected override void RegistoUtente(List<Utente> utentes)

    {
        base.RegistoUtente(utentes); //o base.RegistoUtente(utentes) permite executar o método descrito na superclasse Colaborador, evitando assim a duplicação do código
    }

    public void PreConsulta()
    {

    }

}
