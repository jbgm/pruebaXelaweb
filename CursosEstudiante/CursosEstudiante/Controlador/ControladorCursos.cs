using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosEstudiante.Controlador
{
    public class ControladorCursos
    {
        private static ControladorCursos controladorCursos = null;
        private ControladorCursos()
        {

        }
        static public ControladorCursos Contolador_Cursos
        {
            get
            {
                return controladorCursos == null ? controladorCursos = new ControladorCursos() : controladorCursos;
            }
        }

        public void obtenerListadoDeCursos()
        {

        }

        public void CrearNuevoCurso()
        {
            Vistas.CrearCurso vistaNuevoCurso = new Vistas.CrearCurso();
            vistaNuevoCurso.ShowDialog();

            CursosEstudiante.Curso curso = new Curso() { Nombre = vistaNuevoCurso.Nombre };

            if (validar(curso))
            {
                Ingresar_A_DB(curso);
            }
        }

        public bool validar(Curso curso)
        {
            if (string.IsNullOrWhiteSpace(curso.Nombre))
                return false;
            return true;
        }

        public void Ingresar_A_DB(Curso curso)
        {
            Form1.ContextoDB.Cursos.Add(curso);

            Form1.ContextoDB.SaveChanges();
        }

    }
}
