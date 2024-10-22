using Library;

namespace Program;

public class Program
{
    static void Main(string[] args) // Elimina el segundo Main y ajusta el formato.
    {
        {
            Heroes hero = new Heroes("Aragorn");
            Malos enemy = new Malos("Orc", 3);
            Malos enem = new Malos("Orce", 4);


            Encuentro encuentro = new Encuentro(new List<Heroes> { hero }, new List<Malos> { enemy, enem });
            hero.Puntos_de_ataque = 150;
            enem.Puntos_de_ataque = 200;

            encuentro.DoEncounter();
        }
    }
}