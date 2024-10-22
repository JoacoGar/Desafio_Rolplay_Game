namespace Library;


    public class AtaqueyDefensa : Elementos
    {
        public int Ataque { get; set; }
        public int Defensa { get; set; }

        public AtaqueyDefensa(string nombre, int ataque, int defensa) : base(nombre)
        {
            Ataque = ataque;
            Defensa = defensa;
        }
    }
