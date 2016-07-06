using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosEstudiante.Controlador
{
    public class ControladorAsignaciones
    {
        private static ControladorAsignaciones controladorAsignaciones = null;
        private ControladorAsignaciones()
        {

        }

        static public ControladorAsignaciones Contolador_Asignaciones
        {
            get
            {
                return controladorAsignaciones == null ? controladorAsignaciones = new ControladorAsignaciones() : controladorAsignaciones;
            }
        }

        public void NuevaAsignacion()
        {
            var cursos = (from curso in Form1.ContextoDB.Cursos select curso).ToList();
            var estudiantes = (from estudiante in Form1.ContextoDB.Estudiantes select estudiante).ToList();
            Vistas.AsignarCursos vistaAsignarCursos = new Vistas.AsignarCursos(cursos, estudiantes);
            vistaAsignarCursos.ShowDialog();

            CursosEstudiante.Asignacion asignacion = new Asignacion() { Curso = vistaAsignarCursos.Curso, Estudiante = vistaAsignarCursos.Estuduiante };

            if (validar(asignacion))
            {
                Ingresar_A_DB(asignacion);
            }
        }

        public bool validar(Asignacion asignacion)
        {
            if (asignacion.Curso != null && asignacion.Estudiante  != null)
                return false;
            return true;
        }

        public void Ingresar_A_DB(Asignacion asignacion)
        {
            Form1.ContextoDB.Asignacions.Add(asignacion);

            Form1.ContextoDB.SaveChanges();
        }
    }
}
