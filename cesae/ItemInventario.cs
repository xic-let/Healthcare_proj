using System;

public class ItemInventario
{
	public string Produto;
	public int Quantidade;
	public double Preco;
	
	
	public ItemInventario()
	{

	}

    public ItemInventario(string produto, int quantidade, double preco)
    {
		Produto = produto;
		Quantidade = quantidade;
		Preco = preco;
    }

    
	public double Total()
    {
        return Quantidade * Preco;
    }


}
