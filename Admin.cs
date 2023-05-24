using System;

public class Admin : Colaborador
{
    public List<ItemInventario> inventario = new List<ItemInventario>();

    
    public Admin()
    {

    }

    public Admin(double vencimento, char equipa, string viatura)
        :base(vencimento, equipa, viatura)
    {

    }

    public void AddItemInventario(ItemInventario item)
    {
        inventario.Add(item);
    }
}
