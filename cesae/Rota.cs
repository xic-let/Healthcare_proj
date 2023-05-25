using System;

public class Rota
{
	public DateTime Data;
	public string Origem;
	public string Destino;
	public double Kms;

	
	public Rota()
	{

	}

	public Rota(DateTime data, string origem, string destino, double kms)
	{
		Data = data;
		Origem = origem;
		Destino = destino;
		Kms = kms;
	}
	
	
}
