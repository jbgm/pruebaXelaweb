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
    public partial class IngresarEstudiante : Form
    {
        bool aceptado = false;
        public IngresarEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aceptado = true;
            this.Close();
        }

        public string Nombre
        {
            get {
                return aceptado ? textBox1.Text : null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
