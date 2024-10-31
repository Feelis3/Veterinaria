using Examen_Veterinario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOOFinal
{
    internal class Examen_Veterinario
    {
        static void Main(string[] args)
        {

            Veterinario v = new Veterinario("José Díaz Sánchez", "02588923-F", 37, "Cirugía");
            Perro p1 = new Perro(1234, 8, "Chase", 10, "Husky Siberiano");
            p1.añadirTarea(new Tarea("Vacunar", false, 2));
            p1.añadirTarea(new Tarea("Desparasitar", false, 3));
            p1.añadirTarea(new Tarea("Cortar pelo", true, 4));
            p1.añadirTarea(new Tarea("Operar", true, 1));

            Perro p2 = new Perro(2341, 14, "Marshall", 12, "Labrador");
            p2.añadirTarea(new Tarea("Vacunar", true, 3));
            p2.añadirTarea(new Tarea("Desparasitar", false, 4));
            p2.añadirTarea(new Tarea("Cortar pelo", false, 2));
            p2.añadirTarea(new Tarea("Operar", true, 1));

            Perro p3 = new Perro(3412, 15, "Rocky", 11, "Pastor Alemán");
            p3.añadirTarea(new Tarea("Vacunar", true, 4));
            p3.añadirTarea(new Tarea("Desparasitar", false, 1));
            p3.añadirTarea(new Tarea("Cortar pelo", true, 3));
            p3.añadirTarea(new Tarea("Operar", false, 2));


            //6.c

            Console.WriteLine("6. C\n");


            v.altaPerro(p1);
            v.mostrarPerros();
            v.bajaPerro(p1);
            v.mostrarPerros();
            v.altaPerro(p1);
            v.mostrarPerros();

            //6.d

            Console.WriteLine("\n6. D\n");

            v.altaPerro(p2);
            v.altaPerro(p3);

            Console.WriteLine("Orden habitual:");
            v.mostrarPerros();
            Console.WriteLine("Orden no habitual:");
            v.Perros.Sort(new ComparerPeso());
            v.mostrarPerros();


            //6.e

            Console.WriteLine("\n6. E\n");

            Perro p4 = new Perro(12345, 16, "Perro", 15, "Chiwawa");
            p4.añadirTarea(new Tarea("Vacunar", true, 3));
            p4.añadirTarea(new Tarea("Vacunar", true, 3));
            p4.añadirTarea(new Tarea("Operar", true, 3));
            p4.añadirTarea(new Tarea("Otra cosa", true, 3));

            HashSet<Tarea> list = p4.Seguimiento;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }
        public static string mostrarTareasPendientes(Veterinario v)
        {
            return $"{v.Nombre}={{\n" +
                $"" +
                $"";
        }
    }
}