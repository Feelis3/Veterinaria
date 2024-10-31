namespace Examen_Veterinario;

public class Perro : Mascota,IComparable<Perro>
{
    private string raza;
    private HashSet<Tarea> seguimiento;

    public string Raza { get => raza; set => raza = value; }
    public HashSet<Tarea> Seguimiento { get => seguimiento; set => seguimiento = value; }

    public Perro(int idMascota, int edad, string nombre, double peso, string raza) : base(idMascota, edad, nombre, peso)
    {
        this.raza = raza;
        this.seguimiento = new HashSet<Tarea>();
    }

    public override string ToString()
    {
        string seguimientoLista = string.Join(", ", seguimiento);
        return $"Perro={base.ToString()}, Raza={raza}, Seguimiento= {{{seguimientoLista}}}";
    }

    public void añadirTarea(Tarea tarea)
    {
        this.seguimiento.Add(tarea);
    }

    public int CompareTo(Perro other)
    {
        int porNombre = this.Nombre.CompareTo(other.Nombre);
        if (porNombre == 0)
        {
            return this.Edad.CompareTo(other.Edad);
        }
        return porNombre;
    }
}