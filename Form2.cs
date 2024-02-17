using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Unimar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String nombre;
        String apellido;
        String cedula;
        String carrera;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            apellido = textBox2.Text;
            cedula = textBox3.Text;
            carrera = comboBox1.Text;
            Alumnos alumno = new Alumnos(nombre, apellido, cedula, carrera);
            MessageBox.Show("Alumno registrado con exito");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
