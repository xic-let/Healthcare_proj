using System;

public class Colaborador : User
{
	public double Vencimento;
	public char Equipa;
	public string Viatura;

	
	public Colaborador()
	{

	}

	public Colaborador(double vencimento, char equipa, string viatura)
	{
		Vencimento = vencimento;
		Equipa = equipa;
		Viatura = viatura;
	}
}
