namespace Program;

public class Mago : IPersonaje
{
    public string Nombre { get; set; }
    public int Puntos_de_salud { get; set; }
    public int Puntos_de_ataque { get; set; }
    public int Puntos_de_defensa { get; set; }
    public List<IElementos> ArmasMago { get; set; }
    public List<IElementos> ArmaduraMago { get; set; }
    public LibrosHechizos Libro { get; set; } = new LibrosHechizos();

    public Mago(string nombre)
    {
        Nombre = nombre;
        Puntos_de_salud = 100;
        Puntos_de_ataque =0; // Declaro unos puntos de ataque y de defensa iniciales en 0, dado que los mismos seran otorgados por los distintos elementos.
        Puntos_de_defensa = 0;
        ArmasMago = new List<IElementos>();
        ArmaduraMago = new List<IElementos>();
    }

    public void Atacar(IPersonaje personajeQueAtaca, IPersonaje personajeAtacado)
    {
        personajeAtacado.Puntos_de_salud -= personajeQueAtaca.Puntos_de_ataque - personajeAtacado.Puntos_de_defensa;
        Console.WriteLine($"{personajeQueAtaca.Nombre} ataca a {personajeAtacado.Nombre}:");
        Console.WriteLine(
            $"{personajeAtacado.Nombre}: Puntos de salud: {personajeAtacado.Puntos_de_salud}, Puntos de defensa: {personajeAtacado.Puntos_de_defensa}, Puntos de ataque: {personajeAtacado.Puntos_de_ataque} ");

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
            ArmasMago.Add(elemento);
            Puntos_de_ataque += elemento.Poder_de_ataque;
            Console.WriteLine($"{this.Nombre} a recibido {elemento}");
        }
        else if (Armaduras.listaArmaduras.Contains(elemento))
        {
            ArmaduraMago.Add(elemento);
            Puntos_de_defensa += elemento.Poder_de_defensa;
            Console.WriteLine($"{this.Nombre} a recibido {elemento}");

        }
    }

    public void removeElemento(IElementos elemento)
    {
        if (ArmasMago.Contains(elemento))
        {
            ArmasMago.Remove(elemento);
            Puntos_de_ataque -= elemento.Poder_de_ataque;
            Console.WriteLine($"A {this.Nombre} se le a quitado {elemento}");

        }
        else if (ArmaduraMago.Contains(elemento))
        {
            ArmaduraMago.Remove(elemento);
            Puntos_de_defensa -= elemento.Poder_de_defensa;
            Console.WriteLine($"A {this.Nombre} se le a quitado {elemento}");

        }
    }

    public void conocerPersonaje()
    {
        Console.WriteLine(
            $"Los puntos de ataque de {this.Nombre} son {this.Puntos_de_ataque}, los de defensa {this.Puntos_de_defensa} y sus puntos de salud {this.Puntos_de_salud}");
    }

    public void AtacarConHechizo(Mago personajeAtacado, string nombreHechizo)
        {
            for (int i = 0; i < Libro.LibroHechizos.Count; i++)
            {
                if (Libro.LibroHechizos[i].Nombre_elemento == nombreHechizo)
                {
                    personajeAtacado.Puntos_de_salud  = Libro.LibroHechizos[i].Poder_de_ataque - personajeAtacado.Puntos_de_defensa;
                    Console.WriteLine($"{Nombre} ataca a {personajeAtacado.Nombre}");
                    Console.WriteLine($"{personajeAtacado.Nombre}: Puntos de salud: {personajeAtacado.Puntos_de_salud}, Puntos de defensa: {personajeAtacado.Puntos_de_defensa}, Puntos de ataque: {personajeAtacado.Puntos_de_ataque} ");

                    if (personajeAtacado.Puntos_de_salud <= 0)
                    {
                        Console.WriteLine($"{personajeAtacado.Nombre} se a debilitado ");

                    }
                    
                    
                }
            }
        }
}


