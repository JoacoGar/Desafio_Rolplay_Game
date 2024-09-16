namespace Program;

public class LibrosHechizos
{
    public List<Hechizo> LibroHechizos { get; private set; } = new List<Hechizo>();

    public void AgregarHechizo(Hechizo hechizo)
    {
        LibroHechizos.Add(hechizo);
    }
    

}