namespace Program;
public class Program
{
    static void Main()
    {
        Enanos P1 = new Enanos("Pata");
        Armas Arma1 = new Armas("Espada de luz", 10);
        Armaduras Armadura1 = new Armaduras("Armadura de diamante", 15);
        P1.addElemento(Arma1);
        P1.addElemento(Armadura1);
        P1.conocerPersonaje();

        Mago P2 = new Mago("Guerrico");
        Armas Arma2 = new Armas("Hacha de diamante", 25);
        P2.addElemento(Arma2);
        P2.Atacar(P2, P1);

    }
}