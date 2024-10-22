namespace Library;

    public abstract class Elementos
    {
        public string Nombre { get; set; }

        public Elementos(string nombre)
        {
            Nombre = nombre;
        }
    }