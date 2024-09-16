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

        Elfos Casper = new Elfos("Casper");
        Armas CasperArma = new Armas("bombita de agua", 80);
        Armaduras Fuerte = new Armaduras("Fuerte", 27);
        Casper.addElemento(CasperArma);
        Casper.addElemento(Fuerte);

        Casper.Atacar(Casper, P1);
        
        P1.Curar(P1);
        
        Casper.removeElemento(Fuerte);

        Hechizo sapo = new Hechizo("sapo", 87, 54); 
        P2.Libro.AgregarHechizo(sapo); 
        P2.AtacarConHechizo(P2, Casper, "sapo"); 
        
        Enanos P3 = new Enanos("Casper");
        Armas Arma3 = new Armas("Martillo de la deidad", 20);
        Armaduras Armadura3 = new Armaduras("Armadura de mitrilo", 12);
        P3.addElemento(Arma3);
        P3.addElemento(Armadura3);
        P3.conocerPersonaje();

        Mago P4 = new Mago("Yuno");
        Armas Arma4 = new Armas("Varita", 5);
        P4.addElemento(Arma4);
        P4.conocerPersonaje();

        P3.Atacar(P3, P4);

        Armas ArmaNueva = new Armas("Hacha de minotauro", 30);
        P3.removeElemento(Arma3);
        P3.addElemento(ArmaNueva);

        P3.Atacar(P3, P4);
        
        Mago Frieren = new Mago("Frieren");
        Armas ArcoSabiduria = new Armas("Arco de la Sabiduría", 18);
        Armaduras PecheraElfica = new Armaduras("Pechera Élfica", 10);
        Frieren.addElemento(ArcoSabiduria);
        Frieren.addElemento(PecheraElfica);
        Frieren.conocerPersonaje();
        
        Enanos Asta = new Enanos("Asta");
        Armas HachaCalamidad = new Armas("Hacha de la Calamidad", 25);
        Asta.addElemento(HachaCalamidad);
        Asta.conocerPersonaje();
        
        Hechizo Oscuridad = new Hechizo("Oscuridad", 60, 40);
        Frieren.Libro.AgregarHechizo(Oscuridad);

        Frieren.AtacarConHechizo(Frieren, Asta, "Oscuridad");
        
        Asta.Curar(Asta);
        
        Asta.Atacar(Asta, Frieren);
        


    }
}
