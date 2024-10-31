namespace Examen_Veterinario;

public abstract class Mascota
{
    private int idMascota,edad;
    private string nombre;
    private double peso;

    protected Mascota(int idMascota, int edad, string nombre, double peso)
    {
        this.idMascota = idMascota;
        this.edad = edad;
        this.nombre = nombre;
        this.peso = peso;
    }

    public int IdMascota { get => idMascota; set => idMascota = value; }
    public int Edad { get => edad; set => edad = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public double Peso { get => peso; set => peso = value; }

    public override string ToString()
    {
        return $"{{ID={idMascota},Nombre={nombre},Peso={peso},Edad={edad}}}";
    }

    
}