namespace Program;

public class Mago : IPersonaje
{
    public string Nombre { get; set; }
    public int Puntos_de_salud { get; set; }
    public int Puntos_de_ataque { get; set; }   
    public int Puntos_de_defensa { get; set; }
    public List<IElementos> ArmasMago { get; set; }
    public List <IElementos> ArmaduraMago { get; set; }
    public List <IElementos> Libro_de_hechizos { get; set; }
    
    public Mago(string nombre)
    {
        Nombre = nombre;
        Puntos_de_salud = 100;
        Puntos_de_ataque = 0;                                   // Declaro unos puntos de ataque y de defensa iniciales en 0, dado que los mismos seran otorgados por los distintos elementos.
        Puntos_de_defensa = 0;
        ArmasMago = new List<IElementos>();
        ArmaduraMago = new List<IElementos>();
        Libro_de_hechizos = new List<IElementos>();
    } 
    public void Atacar(IPersonaje personajeQueAtaca, IPersonaje personajeAtacado)
    {
        personajeQueAtaca.Puntos_de_salud -= personajeAtacado.Puntos_de_ataque;
    }

    public void Curar(IPersonaje personaje)
    {
        personaje.Puntos_de_salud = 100;
    }
    
    public void addElemento(IElementos elemento) 
    {
        if (Armas.listaArmas.Contains(elemento))
        {
            ArmasMago.Add(elemento);
            Puntos_de_ataque += elemento.Poder_de_ataque;
        }
        else if (Armas.listaArmaduras.Contains(elemento))
        {
            ArmaduraMago.Add(elemento);
            Puntos_de_defensa += elemento.Poder_de_defensa;
        }
    }
    
    public void removeElemento(IElementos elemento)
    {
        if (ArmasMago.Contains(elemento))
        {
            ArmasMago.Remove(elemento);
            Puntos_de_ataque -= elemento.Poder_de_ataque;
        }
        else if (ArmaduraMago.Contains(elemento))
        {
            ArmaduraMago.Remove(elemento);
            Puntos_de_defensa -= elemento.Poder_de_defensa;
        }
    }
}   

