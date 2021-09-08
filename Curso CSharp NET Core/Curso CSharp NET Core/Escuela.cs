using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CSharp_NET_Core
{
    class Escuela
    {
        public string Instituto { get; set; }

        public List<Estudiante> estudiantes;        //declaracion

        

         public Escuela()
        {
            estudiantes = new List<Estudiante>();   //instanciamiento
        }


        public void AgregarEstudiante(Estudiante nuevoEstudiante) 
        {
            estudiantes.Add(nuevoEstudiante);        
        }

        public bool buscarEstudiante(string unEstudiante)
        {
            bool estudianteEncontrado = false;
            int i = 0;

            while ((estudiantes.Count > i) && (estudianteEncontrado == false)) 
            {

                if (estudiantes[i].Nombre.Equals(unEstudiante))
                {
                    estudianteEncontrado = true;
                }
                else 
                {
                    i++;
                }

            }

            if (estudianteEncontrado)
            {
                Console.WriteLine(      $"ID: {i}" + "\n" +
                                        $"Nombre: {estudiantes[i].Nombre}" + "\n" +
                                        $"Edad: {estudiantes[i].Edad} años" + "\n" +
                                        $"Calificacion Promedio: {estudiantes[i].Calificacion} puntos" + "\n" +
                                        $"-------------------------------");
                return true;
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado" + "\n" +
                                   $"-------------------------------");
                return false;
            }


            //return estudianteEncontrado;
        }




    }
}
