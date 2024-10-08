public class Elfos :IPersonaje
{
    public string Nombre { get; set; }
    public int Puntos_de_salud { get; set; }
    public int Puntos_de_ataque { get; set; }   
    public int Puntos_de_defensa { get; set; }
    public List<IElementos> ArmasElfos { get; set; }
    public List <IElementos> ArmaduraElfos { get; set; }
    
    public Elfos(string nombre)
    {
        Nombre = nombre;
        Puntos_de_salud = 100;
        Puntos_de_ataque = 0;                                   // Declaro unos puntos de ataque y de defensa iniciales en 0, dado que los mismos seran otorgados por los distintos elementos.
        Puntos_de_defensa = 0;
        ArmasElfos = new List<IElementos>();
        ArmaduraElfos = new List<IElementos>();
    } 
    public void Atacar(IPersonaje personajeQueAtaca, IPersonaje personajeAtacado)
    {
        personajeAtacado.Puntos_de_salud -= personajeQueAtaca.Puntos_de_ataque - personajeAtacado.Puntos_de_defensa;
        Console.WriteLine($"{personajeQueAtaca.Nombre} ataca a {personajeAtacado.Nombre}:");
        Console.WriteLine($"{personajeAtacado.Nombre}: Puntos de salud: {personajeAtacado.Puntos_de_salud}, Puntos de defensa: {personajeAtacado.Puntos_de_defensa}, Puntos de ataque: {personajeAtacado.Puntos_de_ataque} ");
        
        if (personajeAtacado.Puntos_de_salud <= 0)
        {
            Console.WriteLine($"{personajeAtacado.Nombre} se a debilitado ");

        }
    }

    public void Curar(IPersonaje personaje)
    {
        personaje.Puntos_de_salud = 100;
        Console.WriteLine($"{this.Nombre} se a curado, su nuevo punto de salud es 100");

    }
    
    public void addElemento(IElementos elemento) 
    {
        if (Armas.listaArmas.Contains(elemento))
        {
            ArmasElfos.Add(elemento);
            Puntos_de_ataque += elemento.Poder_de_ataque;
            Console.WriteLine($"{this.Nombre} a recibido {elemento}");
        }
        else if (Armaduras.listaArmaduras.Contains(elemento))
        {
            ArmaduraElfos.Add(elemento);
            Puntos_de_defensa += elemento.Poder_de_defensa;
            Console.WriteLine($"{this.Nombre} a recibido {elemento}");

        }
    }
    
    public void removeElemento(IElementos elemento)
    {
        if (ArmasElfos.Contains(elemento))
        {
            ArmasElfos.Remove(elemento);
            Puntos_de_ataque -= elemento.Poder_de_ataque;
            Console.WriteLine($"A {this.Nombre} se le a quitado {elemento}");

        }
        else if (ArmaduraElfos.Contains(elemento))
        {
            ArmaduraElfos.Remove(elemento);
            Puntos_de_defensa -= elemento.Poder_de_defensa;
            Console.WriteLine($"A {this.Nombre} se le a quitado {elemento}");

        }
    }

    public void conocerPersonaje()
    {
        Console.WriteLine($"Los puntos de ataque de {this.Nombre} son {this.Puntos_de_ataque}, los de defensa {this.Puntos_de_defensa} y sus puntos de salud {this.Puntos_de_salud}"); 
    }
}