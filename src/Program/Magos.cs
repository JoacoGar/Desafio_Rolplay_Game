namespace Program;

public class Mago
{
    public string Nombre { get; set; }
    public int Puntos_de_salud { get; set; }
    public int Puntos_de_ataque { get; set; }   
    public int Puntos_de_defensa { get; set; }
    public List<Armas> Arma { get; set; }
    public List <Armaduras> Armadura { get; set; }
    public List <Hechizos> Libro_de_hechizos { get; set; }
    
    public Mago(string nombre, int salud)
    {
        Nombre = nombre;
        Puntos_de_salud = salud;
        Puntos_de_ataque = 5;  // Declaro unos puntos de ataque y de defensa iniciales, dado que los mismos seran otorgados por los distintos elementos.
        Puntos_de_defensa = 0;
        Arma = new List<Armas>();
        Armadura = new List<Armaduras>();
        Libro_de_hechizos = new List<Hechizos>();
    } 
}   

