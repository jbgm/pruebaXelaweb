using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosEstudiante.Controlador
{
    public class ControladorEstudiantes
    {
        private static ControladorEstudiantes controladorEstudiantes = null;
        private ControladorEstudiantes()
        {

        }

        public static ControladorEstudiantes Controlador_Estudiantes 
        {
            get
            {
                return controladorEstudiantes == null ? controladorEstudiantes = new ControladorEstudiantes() : controladorEstudiantes;
            }
        }

        public void obtenerListadoDeEstudiantes()
        {
           
        }

        public void obtenerListadoDeEstudiantesPorCurso()
        {

        }

        public void crearUnNuevoEstudiante()
        {
            Vistas.IngresarEstudiante vistaIngreso = new Vistas.IngresarEstudiante();
            vistaIngreso.ShowDialog();

            CursosEstudiante.Estudiante estudiante = new Estudiante() { nombre = vistaIngreso.Nombre };

            if (validar(estudiante))
            {
                Ingresar_A_DB(estudiante);
            }
        }

        public bool validar(Estudiante estudiante)
        {
            if (string.IsNullOrWhiteSpace(estudiante.nombre))
                return false;
            return true;
        }

        public void Ingresar_A_DB(Estudiante estudiante)
        {
            Form1.ContextoDB.Estudiantes.Add(estudiante);

            Form1.ContextoDB.SaveChanges();
        }
    }
}
