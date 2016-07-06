using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursosEstudiante
{
    public partial class Form1 : Form
    {
        public static ControlAsignacionesEntities ContextoDB = null;
        public static ObjectContext Objetos = null;
        public Form1()
        {
            ContextoDB = new CursosEstudiante.ControlAsignacionesEntities();
            Objetos = ((IObjectContextAdapter)ContextoDB).ObjectContext;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controlador.ControladorEstudiantes.Controlador_Estudiantes.crearUnNuevoEstudiante();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controlador.ControladorCursos.Contolador_Cursos.CrearNuevoCurso();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controlador.ControladorTareas.Controlador_Tareas.crearNuevaTarea();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Controlador.ControladorAsignaciones.Contolador_Asignaciones.NuevaAsignacion();
        }
    }
}
