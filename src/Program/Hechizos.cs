namespace Program;

public class Hechizo: IElementos
{ 
    public string Nombre_elemento { get; set;  }
    public int Poder_de_ataque { get; set;  }
    public int Poder_de_defensa { get; set;  }

    public Hechizo (string nombre, int poderDeAtaque, int poderDeDefensa)
    {
        Nombre_elemento = nombre;
        Poder_de_ataque = poderDeAtaque;
        Poder_de_defensa = poderDeDefensa; 
    }
    
}