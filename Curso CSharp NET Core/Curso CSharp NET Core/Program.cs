using System;

namespace Curso_CSharp_NET_Core
{
    class Program
    {
        static void Main()
        {

            var est1 = new Estudiante();
            est1.Nombre = "Juan Marcelo Lopez Luna";
            est1.Edad = 18;
            est1.Calificacion = 6.90;

            var esc1 = new Escuela();
            esc1.AgregarEstudiante(est1);

            for (int i = 0; i < esc1.estudiantes.Count; i++)
            {
                Console.WriteLine(  $"Nombre: {esc1.estudiantes[i].Nombre}" + "\n" +
                                    $"Edad: {esc1.estudiantes[i].Edad} años" + "\n" +
                                    $"Calificacion Promedio: {esc1.estudiantes[i].Calificacion} puntos" + "\n" +
                                    $"-------------------------------");
            }

            esc1.buscarEstudiante("Pepe");
            esc1.buscarEstudiante("Juan Marcelo Lopez Luna");

            //Otra manera de inicializar/instanciar un objeto
            var est2 = new Estudiante()
            {
                Nombre = "El Loco",
                Edad = 33,
                Calificacion = 9.50
            };

            var est3 = new Estudiante()
            {
                Nombre = "Eli",
                Edad = 45,
                Calificacion = 8.50
            };

            esc1.AgregarEstudiante(est2);
            esc1.AgregarEstudiante(est3);

            Console.ReadKey();

        }
    }
}
