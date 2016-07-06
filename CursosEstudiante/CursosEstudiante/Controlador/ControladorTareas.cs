using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosEstudiante.Controlador
{
    public class ControladorTareas
    {
        private static ControladorTareas controladorTareas = null;
        private ControladorTareas()
        {

        }

        static public ControladorTareas Controlador_Tareas
        {
            get
            {
                return controladorTareas == null ? controladorTareas = new ControladorTareas() : controladorTareas;
            }
        }


        public void obtenerTareasPorCurso(Curso curso)
        {
            
        }

        public void crearNuevaTarea()
        {
            var cursos = (from curso in Form1.ContextoDB.Cursos select curso).ToList();
            Vistas.CrearTarea vistaCrearTarea = new Vistas.CrearTarea(cursos);
            vistaCrearTarea.ShowDialog();

            CursosEstudiante.Tarea tarea = new Tarea() { Nota = vistaCrearTarea.Ponderacion, Tipo = vistaCrearTarea.TipoDeTarea, Curso = vistaCrearTarea.Curso};

            if (validar(tarea))
            {
                Ingresar_A_DB(tarea);
            }
        }

        public bool validar(Tarea tarea)
        {
            if (string.IsNullOrWhiteSpace(tarea.Tipo) && tarea.Nota  != 0 && tarea.Curso != null)
                return false;
            return true;
        }

        public void Ingresar_A_DB(Tarea tarea)
        {
            Form1.ContextoDB.Tareas.Add(tarea);

            Form1.ContextoDB.SaveChanges();
        }

    }
}
