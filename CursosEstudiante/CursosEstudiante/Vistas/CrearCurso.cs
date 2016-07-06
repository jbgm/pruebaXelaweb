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
    public partial class CrearCurso : Form
    {
        bool aceptado = false;
        public CrearCurso()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get
            {
                return aceptado ? textBox1.Text : null;
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
