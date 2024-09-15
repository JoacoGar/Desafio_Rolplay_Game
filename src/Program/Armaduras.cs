namespace Program;

public class Armaduras : IElementos
{
    
    public static List<IElementos> listaArmaduras { get; set; }
    public string Nombre_elemento { get; set;  }
    public int Poder_de_ataque { get; set;  }
    public int Poder_de_defensa { get; set;  }

    public Armaduras(string nombre, int poderDeDefensa)
    {
        Nombre_elemento = nombre;
        Poder_de_ataque = 0;
        Poder_de_defensa = poderDeDefensa; // Para las armas seteo el valor de defensa en 0 siempre
        listaArmaduras.Add(this);
    }

}