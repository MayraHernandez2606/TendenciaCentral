using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TendenciaCentral
{
    public partial class Form1 : Form
    {
        int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sum = 0, med = 0, dato2 = 0;
            
            // Iterar a través de las filas del DataGridView y sumar los valores de la columna "Datos"
            foreach (DataGridViewRow row in TablaDatos.Rows)
            {
                if (row.Cells["datos"].Value != null)
                {
                    sum += Convert.ToDouble(row.Cells["datos"].Value);
                }
            }

            dato2 = Convert.ToDouble(txtNumDatos.Text);

            // Aplicacion de la media aritmetica de los datos
            med = (sum) / dato2 ;
            txtMedia.Text = Convert.ToString(med);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar un nuevo reglon
            int n = TablaDatos.Rows.Add();

            //Colocar la informacion en los textbox
            TablaDatos.Rows[n].Cells[0].Value = txtDatos.Text;

            //Limpiar los text box
            txtDatos.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
