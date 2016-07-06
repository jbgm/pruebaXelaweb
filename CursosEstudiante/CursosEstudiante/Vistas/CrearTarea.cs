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
    public partial class CrearTarea : Form
    {
        bool aceptado = false;
        List<Curso> cursos = null;
        public CrearTarea(List<Curso> cursos)
        {
            this.cursos = cursos;
            InitializeComponent();
            foreach (var item in cursos)
            {
                comboBox1.Items.Add(item.Nombre);
            }
        }

        public string TipoDeTarea
        {
            get
            {
                return aceptado ? textBox1.Text : null;
            }
        }

        public int Ponderacion 
        {
            get { return aceptado ? (int)numericUpDown1.Value : 0; }
        }

        public Curso Curso
        {
            get
            {
                return aceptado ? cursos[comboBox1.Items.IndexOf(comboBox1.SelectedItem)] : null;
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
