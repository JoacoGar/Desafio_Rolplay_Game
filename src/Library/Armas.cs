namespace Library;

public class Arma : Elementos
{
    public int Ataque { get; set; }

    public Arma(string nombre, int ataque) : base(nombre)
    {
        Ataque = ataque;
    }
}
