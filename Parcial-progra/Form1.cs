using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_progra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            String[,] area = {
      {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectareas" },
            };
            
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int de, a, conversor;
            double cantidad, r;
            de = cboDeConver.SelectedIndex;
            a = cboAConver.SelectedIndex;
            conversor = cboAConver.SelectedIndex;

            cantidad = double.Parse(txtCantidad.Text);
          
            double[] area = { 10.7639, 0.698896, 0.836127, 1, 628.8, 6474.9702758, 10000 };
           

            r = area[de] / area[a] * cantidad;
            lblRespuesta.Text = "Respuesta: " + Math.Round(r,6);
            




        }
    }
}
