namespace Library;

public class Heroes : Personaje
{
    public int VP { get; set; }

    public Heroes(string nombre) : base(nombre, 100)
    {
        VP = 0;
    }

    public override void Atacar(Personaje objetivo)
    {
        if (objetivo is Malos atacado  )
        {
            atacado.Defensa(Puntos_de_ataque);
            
            if (atacado.Puntos_de_salud <= 0)
            {
                GanarVP(atacado.VP);
            }
        }
       
    }

    public void GanarVP(int vp)
    {
        VP += vp;
        Console.WriteLine($"{Nombre} ganó {vp} VP. Acumula {VP} puntos.");
        if (VP >= 5)
        {
            Curarse();
        }
    }

    private void Curarse()
    {
        Puntos_de_salud = 100;
        Console.WriteLine($"{Nombre} se ha curado");
    }
}
