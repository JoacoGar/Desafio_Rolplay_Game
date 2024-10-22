namespace Library;

public class Malos: Personaje
{
    public int VP { get; set; }

    public Malos(string nombre, int vp) : base(nombre, 100)
    {
        VP = vp;
    }

    
    public override void Atacar(Personaje objetivo)
    {
        objetivo.Defensa(Puntos_de_ataque);
    }
}