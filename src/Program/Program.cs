using Library;

namespace Programa;

public class Programa
{
    static void Main() 
    {
        {
            Heroes heroe1 = new Heroes("Gabriel");
            Heroes heroe2 = new Heroes("Jose");
            
            Malos enemigo1 = new Malos("ElPata", 2);
            Malos enemigo2 = new Malos("Valentina", 5);
            Malos enemigo3 = new Malos("ElJota", 8);
            
            heroe1.Puntos_de_ataque = 120;
            heroe1.Puntos_de_defensa = 20;

            heroe2.Puntos_de_ataque = 80;
            heroe2.Puntos_de_defensa = 40;
            
            enemigo1.Puntos_de_ataque = 30;
            enemigo1.Puntos_de_defensa = 10;

            enemigo2.Puntos_de_ataque = 40;
            enemigo2.Puntos_de_defensa = 15;

            enemigo3.Puntos_de_ataque = 60;
            enemigo3.Puntos_de_defensa = 25;
            
            Encuentro encuentro = new Encuentro(
                new List<Heroes> { heroe1, heroe2 }, 
                new List<Malos> { enemigo1, enemigo2, enemigo3 }
            );
            
            encuentro.DoEncounter();
        }
    }
}