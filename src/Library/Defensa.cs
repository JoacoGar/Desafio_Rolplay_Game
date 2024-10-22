namespace Library;

public class Defensa : Elementos
{
    public int Escudo { get; set; }

    public Defensa(string nombre, int escudo) : base(nombre)
    {
        Escudo = escudo;
    }
}