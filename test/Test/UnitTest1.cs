using Library; 

namespace Test
{
    public class Tests
    {
        [Test]
        public void TestArma()
        {
            
            var nombre = "Espada";
            var ataque = 50;

            
            var arma = new Arma(nombre, ataque);

            
            Assert.AreEqual(nombre, arma.Nombre);
            Assert.AreEqual(ataque, arma.Ataque);
        }

        [Test]
        public void TestAtaqueyDefensa()
        {
            var nombre = "Espada con escudo";
            var ataque = 40;
            var defensa = 20;
            
            var item = new AtaqueyDefensa(nombre, ataque, defensa);
            
            Assert.AreEqual(nombre, item.Nombre);
            Assert.AreEqual(ataque, item.Ataque);
            Assert.AreEqual(defensa, item.Defensa);
        }

        [Test]
        public void TestDefensa()
        {
            
            var nombre = "Escudo";
            var escudo = 30;

            
            var defensa = new Defensa(nombre, escudo);

            
            Assert.AreEqual(nombre, defensa.Nombre);
            Assert.AreEqual(escudo, defensa.Escudo);
        }

        [Test]
        public void TestHeroes()
        {
            
            var nombre = "Héroe";
            
            var heroe = new Heroes(nombre);
            
            Assert.AreEqual(nombre, heroe.Nombre);
            Assert.AreEqual(0, heroe.VP);
            Assert.AreEqual(100, heroe.Puntos_de_salud);
        }

        [Test]
        public void TestHeroesPV()
        {
            var heroe = new Heroes("Héroe");
            
            heroe.GanarVP(3);
            
            Assert.AreEqual(3, heroe.VP);
        }

        [Test]
        public void TestMalos()
        {
            var nombre = "Villano";
            var vp = 5;
            
            var malo = new Malos(nombre, vp);
            
            Assert.AreEqual(nombre, malo.Nombre);
            Assert.AreEqual(vp, malo.VP);
            Assert.AreEqual(100, malo.Puntos_de_salud);
        }

        [Test]
        public void TestEncuentro()
        {
            var encuentro = new Encuentro(new List<Heroes>(), new List<Malos>());
            
            encuentro.DoEncounter();

        }
    }
}
