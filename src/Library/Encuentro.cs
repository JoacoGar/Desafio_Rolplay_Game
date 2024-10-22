

namespace Library;

public class Encuentro
{
    public List<Heroes> Heroes { get; set; }
    public List<Malos> Malos { get; set; }

    public Encuentro(List<Heroes> heroes, List<Malos> malos)
    {
        Heroes = heroes;
        Malos = malos;
    }

    public void DoEncounter()
    {
        if (!Malos.Any() || !Heroes.Any())
        {
            Console.WriteLine("No hay encuentro");
            return;
        }

        bool end = false;

        while (!end)
        {

            Console.WriteLine("Atacan los malos");
            TurnoEnemigos();

            if (Heroes.Count == 0)
            {
                Console.WriteLine("Ganaron los malos");
                end = true;
                break;
            }

            Console.WriteLine("Atacan los Heroes");
            TurnoHeroes();

            if (Malos.Count == 0)
            {
                Console.WriteLine("Ganaron los heroes");
                end = true;
                break;
            }

        }
    }

    public void TurnoEnemigos()
    {
        int contador = 0;

        foreach (var enemigo in Malos.ToList())
        {
            if (Heroes.Count == 0)
            {
                break;
            }

            Heroes hero = Heroes[contador];
            int restarVida = enemigo.Puntos_de_ataque;
            hero.Puntos_de_salud -= restarVida;

            Console.WriteLine($"{enemigo.Nombre} atacó a {hero.Nombre}, restándole {restarVida} puntos de vida.");

            if (hero.Puntos_de_salud <= 0)
            {
                Console.WriteLine($"{hero.Nombre} fue abatido.");
                Heroes.Remove(hero);
            }

            if (Heroes.Count > 0)
            {
                contador = (contador + 1) % Heroes.Count; 
            }
        }
    }

    public void TurnoHeroes()
    {
        foreach (var hero in Heroes.ToList())
        {
            foreach (var enemigo in Malos.ToList())
            {
                int restarVida = hero.Puntos_de_ataque;
                enemigo.Puntos_de_salud -= restarVida;

                Console.WriteLine($"{hero.Nombre} atacó a {enemigo.Nombre}, restandole {restarVida} puntos de vida.");

                if (enemigo.Puntos_de_salud <= 0)
                {
                    Console.WriteLine($"{enemigo.Nombre} fue abatido.");
                    hero.VP += enemigo.VP;
                    Malos.Remove(enemigo);
                }

                if (hero.VP >= 5)
                {
                    hero.Puntos_de_salud = 100;
                    hero.VP = 0;
                    Console.WriteLine($"El héroe {hero.VP} ha recargado su vida al 100.");
                }

                if (Malos.Count == 0)
                {
                    break;
                }
            }

            
        }
    }


    
}

