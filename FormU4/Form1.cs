using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormU4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciamos la clase hija derivada
                ArticuloLiquidacion prod = new ArticuloLiquidacion();
                prod.Descripcion = txtArticulo.Text;
                prod.PrecioBase = double.Parse(txtPrecioBase.Text);

                if (prod.PrecioBase < 0) throw new ArgumentException();

                // Variable polimórfica de la Interfaz
                ICobrable itemCaja = prod;

                // Texto ultra corto y limpio para evitar que se desborde el ListBox
                lstTicket.Items.Add($"{prod.Descripcion} (${prod.PrecioBase:F2}) -> Liquidación: ${itemCaja.CalcularTotal():F2}");

                // Limpieza de campos
                txtArticulo.Clear();
                txtPrecioBase.Clear();
                txtArticulo.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, introduce datos de producto válidos.", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
