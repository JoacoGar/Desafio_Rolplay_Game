
public class Armas : IElementos
{
    public static List<IElementos> listaArmas { get; set; } = new List<IElementos>();
    public string Nombre_elemento { get; set;  }
    public int Poder_de_ataque { get; set;  }
    public int Poder_de_defensa { get; set;  }

    public Armas(string nombre, int poderDeAtaque)
    {
        Nombre_elemento = nombre;
        Poder_de_ataque = poderDeAtaque;
        Poder_de_defensa = 0; // Para las armas seteo el valor de defensa en 0 siempre
        listaArmas.Add(this);
    }
}
