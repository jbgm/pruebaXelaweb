using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursosEstudiante.Vistas
{
    public partial class AsignarCursos : Form
    {
        List<Curso> Cursos = null;
        List<Estudiante> Estudiantes = null;
        bool aceptado = false;
        public AsignarCursos(List<Curso> cursos, List<Estudiante> estudiantes)
        {
            Cursos = cursos;
            Estudiantes = estudiantes;
            InitializeComponent();

            foreach (var item in estudiantes)
            {
                comboBox1.Items.Add(item.nombre);
            }
            foreach (var item in cursos)
            {
                comboBox2.Items.Add(item.Nombre);
            }
        }


        public Curso Curso
        {
            get
            {
                return aceptado ? Cursos[comboBox2.Items.IndexOf(comboBox2.SelectedItem)] : null;
            }
        }

        public Estudiante Estuduiante
        {
            get
            {
                return aceptado ? Estudiantes[comboBox1.Items.IndexOf(comboBox1.SelectedItem)] : null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            aceptado = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
