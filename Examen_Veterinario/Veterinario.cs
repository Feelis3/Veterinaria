namespace Examen_Veterinario;

public class Veterinario : PersonalClinica
{
    private string especialidad;
    private List<Perro> perros;
    public Veterinario(string nombre, string dni, int edad, string especialidad) : base(nombre, dni, edad)
    {
        this.especialidad = especialidad;
        this.perros = new List<Perro>();
    }

    public string Especialidad { get => especialidad; set => especialidad = value; }
    public List<Perro> Perros { get => perros; set => perros = value; }

    public void altaPerro(Perro perro)
    {
        this.perros.Add(perro);
    }

    public void bajaPerro(Perro perro)
    {
        this.perros.Remove(perro);
    }

    public void mostrarPerros()
    {
        foreach (var item in perros)
        {
            Console.WriteLine(item);
        }
    }
    
    public override string ToString()
    {
        string perros = string.Join(", ", this.perros);

        return $"Veterinario={{ {base.ToString()}, Especialidad={this.especialidad},Perros={{{perros}}}";
    }


    
    
}