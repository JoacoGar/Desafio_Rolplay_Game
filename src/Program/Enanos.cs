namespace Program;

public class Enanos : IPersonaje
{
      public string Nombre { get; set; }
    public int Puntos_de_salud { get; set; }
    public int Puntos_de_ataque { get; set; }   
    public int Puntos_de_defensa { get; set; }
    public List<IElementos> ArmasEnanos { get; set; }
    public List <IElementos> ArmaduraEnanos { get; set; }
    
    public Enanos(string nombre)
    {
        Nombre = nombre;
        Puntos_de_salud = 100;
        Puntos_de_ataque = 0;                                   // Declaro unos puntos de ataque y de defensa iniciales en 0, dado que los mismos seran otorgados por los distintos elementos.
        Puntos_de_defensa = 0;
        ArmasEnanos = new List<IElementos>();
        ArmaduraEnanos = new List<IElementos>();
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
        Console.WriteLine($"{this.Nombre} se a curado");

    }
    
    public void addElemento(IElementos elemento) 
    {
        if (Armas.listaArmas.Contains(elemento))
        {
            ArmasEnanos.Add(elemento);
            Puntos_de_ataque += elemento.Poder_de_ataque;
            Console.WriteLine($"{this.Nombre} a recibido {elemento}");
        }
        else if (Armaduras.listaArmaduras.Contains(elemento))
        {
            ArmaduraEnanos.Add(elemento);
            Puntos_de_defensa += elemento.Poder_de_defensa;
            Console.WriteLine($"{this.Nombre} a recibido {elemento}");

        }
    }
    
    public void removeElemento(IElementos elemento)
    {
        if (ArmasEnanos.Contains(elemento))
        {
            ArmasEnanos.Remove(elemento);
            Puntos_de_ataque -= elemento.Poder_de_ataque;
            Console.WriteLine($"A {this.Nombre} se le a quitado {elemento}");

        }
        else if (ArmaduraEnanos.Contains(elemento))
        {
            ArmaduraEnanos.Remove(elemento);
            Puntos_de_defensa -= elemento.Poder_de_defensa;
            Console.WriteLine($"A {this.Nombre} se le a quitado {elemento}");

        }
    }

    public void conocerPersonaje()
    {
        Console.WriteLine($"Los puntos de ataque de {this.Nombre} son {this.Puntos_de_ataque}, los de defensa {this.Puntos_de_defensa} y sus puntos de salud {this.Puntos_de_salud}"); 
    }
}