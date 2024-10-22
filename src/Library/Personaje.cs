namespace Library;

public abstract class Personaje
{
    public string Nombre { get; set; }
    public int Puntos_de_salud { get; set; }
    public int Puntos_de_ataque { get; set; }
    public int Puntos_de_defensa { get; set; }
    public List<Elementos> Items { get; set; }


    public Personaje(string nombre, int salud)
    {
        Nombre = nombre;
        Puntos_de_salud = salud;
        Puntos_de_ataque = 0;
        Puntos_de_defensa = 0;
    }

    public void AgregarElemento(Elementos elemento)
    {
        Items.Add(elemento);
        if (elemento is Arma arma)

        {
            Puntos_de_ataque += arma.Ataque;
        }
        else if (elemento is Defensa defensa)
        {
            Puntos_de_defensa += defensa.Escudo;
        }
        else if (elemento is AtaqueyDefensa item)
        {
            Puntos_de_ataque += item.Ataque;
            Puntos_de_defensa += item.Defensa;
        }
    }

    
    public void EliminarItem(Elementos elemento)
    {
        if (Items.Contains(elemento))
        {
            Items.Remove(elemento);
            if (elemento is Arma ataque)
            {
                Puntos_de_ataque -= ataque.Ataque;
            }
            else if (elemento is Defensa defensa)
            {
                Puntos_de_defensa -= defensa.Escudo;
            }
            else if (elemento is AtaqueyDefensa item)
            {
                Puntos_de_ataque -= item.Ataque;
                Puntos_de_defensa -= item.Defensa;
            }
        }
    }
    public void conocerPersonaje()
    {
        Console.WriteLine($"Los puntos de ataque de {this.Nombre} son {this.Puntos_de_ataque}, los de defensa {this.Puntos_de_defensa} y sus puntos de salud {this.Puntos_de_salud}");
    }
    
    public abstract void Atacar(Personaje objetivo);
    
    public void Defensa(int ataque)
    {
        Puntos_de_salud -= ataque - Puntos_de_defensa;
        Console.WriteLine($"{Nombre} recibió un ataque de {ataque} y le quedan {Puntos_de_salud} puntos de salud.");
        
    }


}