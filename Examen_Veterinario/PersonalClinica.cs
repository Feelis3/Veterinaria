namespace Examen_Veterinario;

public abstract class PersonalClinica
{
    private string nombre, dni;
    private int edad;

    public PersonalClinica(string nombre, string dni, int edad)
    {
        this.nombre = nombre;
        this.dni = dni;
        this.edad = edad;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Dni { get => dni; set => dni = value; }
    public int Edad { get => edad; set => edad = value; }

    public override string ToString()
    {
        return $"{{Nombre: {nombre}, Dni: {dni}, Edad: {edad}}}";
    }

    
}