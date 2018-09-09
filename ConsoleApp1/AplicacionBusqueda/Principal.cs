using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {

            }
        }

        private void btn_numdocs_Click(object sender, EventArgs e)
        {

        }

        private void btn_escalafon_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file | *.txt";
            saveFileDialog1.Title = "Guardar escalaf�n";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                controlador.pathEscalafon = saveFileDialog1.FileName;
            }
        }

        private void btn_html_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "HTML file | *.html";
            saveFileDialog1.Title = "Guardar html";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                controlador.pathHTML = saveFileDialog1.FileName;
            }
        }

        private void btn_stopwords_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            this.controlador.pathStopwords = openFileDialog1.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btn_coleccion_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.controlador.pathCollection = fbd.SelectedPath;
                }
            }
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

        private void btn_indexar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "";
            saveFileDialog1.Title = "Guardar �ndice";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                this.controlador.pathIndex = saveFileDialog1.FileName;
                this.controlador.Set_index();
                //this.controlador.Write_index();
                MessageBox.Show("Indice completado.");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            controlador.numDocs = Int32.Parse(entrada_numDocs.Text);
            string consulta = entrada_consulta.Text;
            controlador.Indexar_Consulta(consulta);

            if (rbtn_vec.Checked)
            {
                controlador.Inicializar_Vectorial();
                controlador.Escribir_Escalafon_Vectorial();
            }
            else //BM25 checked
            {
                controlador.Inicializar_BM25();
                controlador.Escribir_Escalafon_BM25();
            }
        }
    }
}
