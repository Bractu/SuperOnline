using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SuperOnline.Form1;

namespace SuperOnline
{
    public partial class FormCarrito : Form
    {
        List<productos> carrito;
        public FormCarrito(List<productos> compras)
        {
            InitializeComponent();
            carrito = compras; 
            llenarTexto();
        }
        private void llenarTexto()
        {
            foreach(var item in carrito)
            {
                if (item.producto == "Manzana")
                {
                    lblManzana.Text = "$ " + item.subtotal.ToString();
                }
                else if (item.producto == "Leche")
                {
                    lblLeche.Text = "$ " + item.subtotal.ToString();
                }
                else if (item.producto == "Pan")
                {
                    lblPan.Text = "$ " + item.subtotal.ToString();
                }
                else if (item.producto == "Arroz")
                {
                    lblArroz.Text = "$ " + item.subtotal.ToString();
                }
                else if (item.producto == "Café")
                {
                    lblCafe.Text = "$ " + item.subtotal.ToString();
                }
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío");
                
            }
            else
            {
                MessageBox.Show("Su compra ha sido exitosa. \nGracias por su compra.");
                this.Close();
            }
            
        }

        private void btnBorrarManzana_Click(object sender, EventArgs e)
        {
            carrito.RemoveAll(item => item.producto == "Manzana");
            lblManzana.Text = "-";
        }

        private void btnBorrarLeche_Click(object sender, EventArgs e)
        {
            carrito.RemoveAll(item => item.producto == "Leche");
            lblLeche.Text = "-";
        }

        private void btnBorrarPan_Click(object sender, EventArgs e)
        {
            carrito.RemoveAll(item => item.producto == "Pan");
            lblPan.Text = "-";
        }

        private void btnBorrarArroz_Click(object sender, EventArgs e)
        {
            carrito.RemoveAll(item => item.producto == "Arroz");
            lblArroz.Text = "-";
        }

        private void btnBorrarCafe_Click(object sender, EventArgs e)
        {
            carrito.RemoveAll(item => item.producto == "Café");
            lblCafe.Text = "-";
        }
    }
}
