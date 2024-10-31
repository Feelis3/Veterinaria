namespace Examen_Veterinario;

public class Tarea : IEquatable<Tarea>
{
    private string nombreTarea;
    private bool estado;
    private int prioridad;

    public string NombreTarea { get => nombreTarea; set => nombreTarea = value; }
    public bool Estado { get => estado; set => estado = value; }
    public int Prioridad { get => prioridad; set => prioridad = value; }

    public Tarea(string nombreTarea, bool estado, int prioridad)
    {
        this.nombreTarea = nombreTarea;
        this.estado = estado;
        this.prioridad = prioridad;
    }

    public override string ToString()
    {
        return $"Tarea = {{NombreTarea={nombreTarea},Estado={estado},Prioridad={prioridad}}}";
    }



    public bool Equals(Tarea other)
    {
        if (nombreTarea.Equals(other.NombreTarea)) {
            return true;
        } else {
            return false;
        }
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(nombreTarea, estado, prioridad, NombreTarea, Estado, Prioridad);
    }
}