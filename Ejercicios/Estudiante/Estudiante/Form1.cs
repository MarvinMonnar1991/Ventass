using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string edad;

            nombre = textBox1.Text;
            edad = textBox2.Text;

            MessageBox.Show("La edad de " + nombre + "es de: " + edad);

        }
    }
}
