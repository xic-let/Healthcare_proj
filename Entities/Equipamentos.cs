﻿using saude_distante_login.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace saude_distante_login.Entities
{
    public class Equipamentos
    {
        
        static List<Equipamentos> Material = new List<Equipamentos>();

        public Equipamentos(string item)
        {
       
            Material.Add(new Equipamentos("ViaturaLigeira"));
            Material.Add(new Equipamentos("ViaturadeRastreio"));
            Material.Add(new Equipamentos("Esfigmamómetro"));
            Material.Add(new Equipamentos("Estetoscópio"));
            Material.Add(new Equipamentos("TirasGlicose"));
            Material.Add(new Equipamentos("TirasColesterol"));

        }

        public void Inventario()
        {
            foreach (Equipamentos item in Material)
            {
                Console.WriteLine(item);
            }
        }
                            

    }

}