using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace AplicacionBusqueda
{
    public partial class Principal : Form
    {
        private ControllerPrincipal controlador;

        public Principal()
        {
            controlador = new ControllerPrincipal();
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_indice_Click(object sender, EventArgs e)
        {

        }

        private void btn_numdocs_Click(object sender, EventArgs e)
        {

        }

        private void btn_escalafon_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "";
            saveFileDialog1.Title = "Guardar escalafón";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                Console.WriteLine("Hola mundo");
            }
        }

        private void btn_html_Click(object sender, EventArgs e)
        {

        }

        private void btn_stopwords_Click(object sender, EventArgs e)
        {

        }

        private void btn_coleccion_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
